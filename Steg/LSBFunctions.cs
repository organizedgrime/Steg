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
    class LSBFunctions
    {

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
            Color pixel;
            int count = 0, red, green, blue, RGB;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    pixel = img.GetPixel(i, j);
                    //pixel2 = pixel;

                    //run 3 times, one for each color value
                    red = pixel.R;
                    green = pixel.G;
                    blue = pixel.B;
                    //apply message
                    for (int k = 0; k < 3; k++)
                    {
                        RGB = (k == 0) ? pixel.R : (k == 1) ? pixel.G : pixel.B;
                        if (count + k < binMessage.Length)
                        {
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
                            else
                            {
                                continue;
                            }
                            pixel = Color.FromArgb(red, green, blue);
                            img.SetPixel(i, j, pixel);
                        }
                    }
                    count += 3;
                    pixels.Add(pixel);
                }
            }
            //going through all of the pixels is now complete
            File.Delete(outputDir + "output.txt");

            //run this to test if the output pixels match your stuff.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputDir + "output.txt", true))
            {

                foreach (Color tempPixel in pixels)
                {
                    //file.WriteLine(tempPixel);
                }
            }

            img.Save(outputDir + "output.png");
        }



        public static void readLSB(string filename)
        {
            Image img = Image.FromFile(filename);
            Program.imageToByteArray(img);
            
        }

    }
}
