using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steg
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //writeLSB(@"C:\Users\Nico\My Documents\Visual Studio 2015\Projects\Steg\lmao.png");
            //readLSB(@"C:\Users\Nico\Desktop\output.png");
        }

        public static void writeLSB(string src, string message)
        {
            Bitmap img = new Bitmap(src);

            //test to insure the image is being selected properly
            //img.Save(@"C:\Users\Nico\Desktop\savage.png");
            string binMessage = "";

            //convert the message to binary 1s and zeros
            foreach (char c in message)
            {
                binMessage += Convert.ToString(c, 2).PadLeft(8, '0');
            }

            ArrayList pixels = new ArrayList();
            Bitmap newImg = new Bitmap(img.Width, img.Height);
            Color pixel, pixel2;
            int count = 0, red, green, blue;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    pixel = img.GetPixel(i, j);
                    pixel2 = pixel;

                    //run 3 times, one for each color value
                    red = pixel.R;
                    green = pixel.G;
                    blue = pixel.B;
                    //apply message
                    //test if the message length has been exceded yet
                    if (count < binMessage.Length)
                    {
                        //red
                        if (binMessage[count] == '0' && pixel.R % 2 == 1)
                        {
                            red = pixel.R - 1;
                        }
                        else if (binMessage[count] == '1' && pixel.R % 2 == 0)
                        {
                            red = pixel.R + 1;
                        }
                    }

                    if (count + 1 < binMessage.Length)
                    {
                        //green
                        if (binMessage[count + 1] == '0' && pixel.G % 2 == 1)
                        {
                            green = pixel.G - 1;
                        }
                        else if (binMessage[count + 1] == '1' && pixel.G % 2 == 0)
                        {
                            green = pixel.G + 1;
                        }
                    }

                    if (count + 3 < binMessage.Length)
                    {
                        //blue
                        if (binMessage[count + 2] == '0' && pixel.B % 2 == 1)
                        {
                            blue = pixel.B - 1;
                        }
                        else if (binMessage[count + 2] == '1' && pixel.B % 2 == 0)
                        {
                            blue = pixel.B + 1;
                        }
                    }
                    pixel2 = Color.FromArgb(red, green, blue);

                    //add the modified pixel to the new bmp
                    newImg.SetPixel(i, j, pixel2);
                    count += 3;
                    pixels.Add(pixel2);
                }
            }
            //going through all of the pixels is now complete
            File.Delete(@"C:\Users\Nico\Desktop\output.txt");

            //run this to test if the output pixels match your stuff.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Nico\Desktop\output.txt", true))
            {

                foreach (Color tempPixel in pixels)
                {
                    file.WriteLine(tempPixel);
                }
            }

            newImg.Save(@"C:\Users\Nico\Desktop\output.png");
        }

        public static void readLSB(string filename)
        {
            Bitmap img = new Bitmap(filename);
            Color pixel;
            string binMessage = "";
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    pixel = img.GetPixel(i, j);
                    if (pixel.R % 2 == 0)
                    {
                        binMessage += "0";
                    }
                    else
                    {
                        binMessage += "1";
                    }
                    if (pixel.G % 2 == 0)
                    {
                        binMessage += "0";
                    }
                    else
                    {
                        binMessage += "1";
                    }
                    if (pixel.B % 2 == 0)
                    {
                        binMessage += "0";
                    }
                    else
                    {
                        binMessage += "1";
                    }
                }
            }
            var data = GetBytesFromBinaryString(binMessage);
            var text = Encoding.ASCII.GetString(data);
            MessageBox.Show(text);

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
