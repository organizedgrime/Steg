using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Steg
{
    class LSBFunctions
    {
        static Bitmap bmp;
        static byte[] rgbValues;
        static BitmapData bmpData;
        static int bytes;
        static IntPtr ptr;


        /*
        /////////////////////////////////////////////////
        Functions for reading and writing the LSB of imgs
        /////////////////////////////////////////////////
        */

        public static void writeLSB(string filename, string outputDir, string message = null, byte[] byteInput = null)
        {
            openImg(filename);
            byte[] byteMsg = null;

            // Based on whether the input is via file or direct text, assign the byteMsg array
            if (message != null)
            {
                byteMsg = new byte[message.Length * sizeof(char)];
                Buffer.BlockCopy(message.ToCharArray(), 0, byteMsg, 0, byteMsg.Length);
            }
            else
            {
                byteMsg = byteInput;
            }

            BitArray bitMsg = new BitArray(byteMsg);

            for (int i = 0; i < byteMsg.Length * 8; i++)
            {
                // If the intended message is different from the preexisting bit, write to it.
                if (bitMsg[i] ^ Convert.ToBoolean(rgbValues[i] & 1))
                {
                    //(n & ~1) | b
                    rgbValues[i] = (byte)((rgbValues[i] & ~1) | Convert.ToInt32(bitMsg[i]));
                }
            }

            closeImg();

            // Save the modified image.
            bmp.Save(@"C:\Users\Nico\Desktop\output.png");
            bmp.Dispose();
        }

        public static void readLSB(string filename, bool concat, bool fileout)
        {

            openImg(filename);

            BitArray message = new BitArray(rgbValues.Length);
            byte[] messageBytes = new byte[message.Length / 8];

            for (int i = 0; i < rgbValues.Length; i++)
            {
                // Add the LSB to bitArray
                message[i] = (rgbValues[i] & 1) == 1;
            }

            closeImg();
            bmp.Dispose();

            // Copy the bits from the image into the byte[]
            message.CopyTo(messageBytes, 0);

            DisplayOutput dispOutput = null;

            if (fileout)
            {
                dispOutput = new DisplayOutput(null, messageBytes);
            }
            else
            {
                // Copy the byte[] into a char[] and into a string
                char[] chars = new char[messageBytes.Length / sizeof(char)];
                Buffer.BlockCopy(messageBytes, 0, chars, 0, messageBytes.Length);
                string str = new string(chars);

                // Cut the gibberish if the user wants you to.
                if (concat)
                {
                    str = Regex.Replace(str, "[^a-zA-Z0-9]", "");
                }

                // Show the message
                dispOutput = new DisplayOutput(str, null);
            }
            dispOutput.Show();
        }



        /*
        /////////////////////////////////////////////////
        Functions for opening and closing images
        /////////////////////////////////////////////////
        */

        public static void openImg(string filename)
        {
            bmp = new Bitmap(filename);
            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

            // Get the address of the first line.
            ptr = bmpData.Scan0;

            bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
        }

        public static void closeImg()
        {
            // Copy the RGB values back to the bitmap & unlock
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
        }
    }
}
