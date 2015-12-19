using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steg
{
    class LSBFunctions
    {

        public static void writeLSB(string src, string outputDir, string message)
        {
            Bitmap bmp = new Bitmap(src);

            //convert the message to binary 1s and zeros
            byte[] byteMsg = new byte[message.Length * sizeof(char)];
            Buffer.BlockCopy(message.ToCharArray(), 0, byteMsg, 0, byteMsg.Length);

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < byteMsg.Length; i++)
            {
                // If the intended message is different from the preexisting bit, write to it.
                if ((byteMsg[i] ^ rgbValues[i] % 2) == 1)
                {
                    //(n & ~1) | b
                    rgbValues[i] = (byte)((rgbValues[i] & ~1) | byteMsg[i]);
                }
            }

            // Copy the RGB values back to the bitmap & unlock
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);

            // Save the modified image.
            bmp.Save(@"C:\Users\Nico\Desktop\output.png");
        }

        public static void readLSB(string filename)
        {
            
            Bitmap bmp = new Bitmap(filename);
            byte[] message = new byte[bmp.Height * bmp.Width];

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);


            int byteCount = -1;
            for (int i = 0; i < rgbValues.Length; i++)
            {
                if (i % 8 == 0)
                    byteCount++;

                // Add the LSB to bitArray
                message[byteCount] += (byte)(rgbValues[i] & (1 << 7));
            }

            // Copy the RGB values back to the bitmap & unlock
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);

            // Show the message
            MessageBox.Show(Encoding.Default.GetString(message));
        }
    }
}
