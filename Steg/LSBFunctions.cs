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

        public static void writeLSB(string filename, string outputDir, string message)
        {
            openImg(filename);

            // Convert the message to encode to binary
            byte[] byteMsg = new byte[message.Length * sizeof(char)];
            Buffer.BlockCopy(message.ToCharArray(), 0, byteMsg, 0, byteMsg.Length);

            for (int i = 0; i < byteMsg.Length; i++)
            {
                // If the intended message is different from the preexisting bit, write to it.
                if ((byteMsg[i] ^ rgbValues[i] % 2) == 1)
                {
                    //(n & ~1) | b
                    rgbValues[i] = (byte)((rgbValues[i] & ~1) | byteMsg[i]);
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
                //(rgbValues[i] & (1 << 0))
                message[i] = (rgbValues[i] & (1 << 0)) == 1;
            }

            closeImg();

            // Copy the bits from the image into the byte[]
            message.CopyTo(messageBytes, 0);

            // Show the message
            MessageBox.Show((messageBytes[0] + ""));
        }


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
            // Get the address of the first line.
            ptr = bmpData.Scan0;
            // Copy the RGB values back to the bitmap & unlock
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
        }
    }
}
