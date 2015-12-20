using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

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

        public static void writeLSB(string filename, string outputDir, string message)
        {
            openImg(filename);

            // Convert the message to encode to binary
            
            byte[] byteMsg = new byte[message.Length * sizeof(char)];
            Buffer.BlockCopy(message.ToCharArray(), 0, byteMsg, 0, byteMsg.Length);
            BitArray bitMsg = new BitArray(byteMsg);

            for (int i = 0; i < byteMsg.Length * 8; i++)
            {
                // If the intended message is different from the preexisting bit, write to it.
                if ((Convert.ToInt32(bitMsg[i]) ^ (rgbValues[i] & 1)) == 1)
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

        public static void readLSB(string filename)
        {

            openImg(filename);

            BitArray message = new BitArray(rgbValues.Length);
            byte[] messageBytes = new byte[message.Length / 8];

            for (int i = 0; i < rgbValues.Length; i++)
            {
                // Add the LSB to bitArray
<<<<<<< HEAD
                //(rgbValues[i] & 1)
                message[i] = (rgbValues[i] & 1) == 1;
                //MessageBox.Show(message[i] + "");
=======
                //(rgbValues[i] & (1 << 0))
                message[i] = (rgbValues[i] & 1) == 1;
>>>>>>> origin/master
            }

            closeImg();
            bmp.Dispose();

            // Copy the bits from the image into the byte[]
            message.CopyTo(messageBytes, 0);

            // Copy the byte[] into a char[] and into a string
            char[] chars = new char[messageBytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(messageBytes, 0, chars, 0, messageBytes.Length);
            string str = new string(chars);

            // Show the message
            MessageBox.Show(str);
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
