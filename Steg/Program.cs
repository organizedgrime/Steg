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
            Application.Run(new MethodChooser());
        }

        public static void writeLSB(string src, string outputDir, string message)
        {
            Bitmap img = new Bitmap(src);

            //test to insure the image is being selected properly
            message = "[/LSB]" + message + "[\\LSB]";
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

                    

                    for (int k = 0; k < 3; k++)
                    {
                        int RGB = (k == 0) ? pixel.R : (k == 1) ? pixel.G : pixel.B;
                        if (count + k < binMessage.Length)
                        {
                            //red
                            if (binMessage[count + k] == '0' && RGB % 2 == 1)
                            {
                                switch (k)
                                {
                                    case 0:
                                        red = pixel.R - 1;
                                        break;

                                    case 1:
                                        green = pixel.G - 1;
                                        break;

                                    case 2:
                                        blue = pixel.B - 1;
                                        break;
                                }
                                
                            }
                            else if (binMessage[count + k] == '1' && RGB % 2 == 0)
                            {
                                switch (k)
                                {
                                    case 0:
                                        red = pixel.R + 1;
                                        break;

                                    case 1:
                                        green = pixel.G + 1;
                                        break;

                                    case 2:
                                        blue = pixel.B + 1;
                                        break;
                                }
                            }
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
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputDir + "output.txt", true))
            {

                foreach (Color tempPixel in pixels)
                {
                    //file.WriteLine(tempPixel);
                }
            }

            newImg.Save(outputDir + "output.png");
        }

        public static int getMaxCharCount(Bitmap img)
        {
            //number of pixels 3 3 / 8 (for 8 bits per char)
            return (img.Width * img.Height * 3) / 8;
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
                    if (binMessage.Contains("010110110101110001001100010100110100001001011101") == true)
                    {
                        binMessage = binMessage.Substring(0, binMessage.Length - (binMessage.Length % 8));
                        break;
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