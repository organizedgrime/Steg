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

            for (int i = 2; i < byteMsg.Length; i++)
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

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static void readLSB(string filename)
        {
            Bitmap bmp = new Bitmap(@"C:\Users\Nico\Desktop\output.png");
            Color pixel;
            string shades = "", final = "";
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    pixel = bmp.GetPixel(i, j);
                    shades += "" + (pixel.R % 2) + "" + (pixel.G % 2) + "" + (pixel.B % 2);
                }
            }

            byte[] bytes = GetBytesFromBinaryString(shades);
            foreach(byte b in bytes)
            {
                final += Convert.ToChar(b);
            }
            File.Delete(@"C:\Users\Nico\Desktop\shades.txt");
            File.WriteAllText(@"C:\Users\Nico\Desktop\shades.txt", final, Encoding.GetEncoding("UTF-8"));
            MessageBox.Show("done");
        }

        public static Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }

    }
}
