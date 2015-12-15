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
            Bitmap img = new Bitmap(src);

            //convert the message to binary 1s and zeros
            var byteMsg = new BitArray(Encoding.UTF8.GetBytes(message));
            byte[] imgData = ImageToByte(img);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    imgData[(int)(i * j / 8)] = 1;

                    if (byteMsg[i * j])
                    {
                        imgData[(int)(i * j / 8)] = (byte)(imgData[(int)(i * j / 8)] | 1);     // Make LSB 1
                    }
                    else
                    {
                        imgData[(int)(i * j / 8)] = (byte)(imgData[(int)(i * j / 8)] & 254);   // Make LSB 0
                    }
                }
            }
            img.Save(outputDir + "output.png");
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static void readLSB(string filename)
        {
            Bitmap bmp = new Bitmap(@"D:\Downloads\shades.png");
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
