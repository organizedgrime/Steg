using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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

        public static void writeLSB(string filename, string outputDir, int brightness)
        {
            openImg(filename);
            //read in the PI file
            StreamReader reader = new StreamReader(@"PI.txt");
            string txt = reader.ReadToEnd();

            if(rgbValues.Length > txt.Length)
            {
                MessageBox.Show("We don't have that many digits of PI, so we might not be able to fill the whole image. :(");
            }

            Action writeLoop = delegate
            {
                int count = 0;

                for (int i = 0; i < rgbValues.Length; i+=3)
                {
                    try
                    {
                        if (rgbValues[i] + rgbValues[i + 1] + rgbValues[i + 2] > 600)
                        {
                            //pixel is white

                            float x = Int32.Parse(txt[count % txt.Length] + "");
                            //Debug.WriteLine(x);
                            Color newColor = FromAHSB(1, x * 36, 1, (float)brightness/100);
                            rgbValues[i] = newColor.R;
                            rgbValues[i + 1] = newColor.G;
                            rgbValues[i + 2] = newColor.B;

                            count++;
                        }
                    }
                    catch(Exception e)
                    {
                        //missed a few pixels.
                    }
                }
            };
            writeLoop();
            closeImg();

            // Save the modified image.
            bmp.Save(LSBForm.initialPath + "\\output.png");
            bmp.Dispose();
            MessageBox.Show("Writing Completed!");
        }

        /*
        /////////////////////////////////////////////////
        Functions for opening and closing images
        /////////////////////////////////////////////////
        */

        public static void openImg(string filename)
        {
            if (File.Exists(filename))
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
        }

        public static void closeImg()
        {
            // Copy the RGB values back to the bitmap & unlock
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
        }

        public static Color FromAHSB(int alpha, float hue, float saturation, float brightness)
        {
            if (0 > alpha
                || 255 < alpha)
            {
                throw new ArgumentOutOfRangeException(
                    "alpha",
                    alpha,
                    "Value must be within a range of 0 - 255.");
            }

            if (0f > hue
                || 360f < hue)
            {
                throw new ArgumentOutOfRangeException(
                    "hue",
                    hue,
                    "Value must be within a range of 0 - 360.");
            }

            if (0f > saturation
                || 1f < saturation)
            {
                throw new ArgumentOutOfRangeException(
                    "saturation",
                    saturation,
                    "Value must be within a range of 0 - 1.");
            }

            if (0f > brightness
                || 1f < brightness)
            {
                throw new ArgumentOutOfRangeException(
                    "brightness",
                    brightness,
                    "Value must be within a range of 0 - 1.");
            }

            if (0 == saturation)
            {
                return Color.FromArgb(
                                    alpha,
                                    Convert.ToInt32(brightness * 255),
                                    Convert.ToInt32(brightness * 255),
                                    Convert.ToInt32(brightness * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (0.5 < brightness)
            {
                fMax = brightness - (brightness * saturation) + saturation;
                fMin = brightness + (brightness * saturation) - saturation;
            }
            else
            {
                fMax = brightness + (brightness * saturation);
                fMin = brightness - (brightness * saturation);
            }

            iSextant = (int)Math.Floor(hue / 60f);
            if (300f <= hue)
            {
                hue -= 360f;
            }

            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
            if (0 == iSextant % 2)
            {
                fMid = (hue * (fMax - fMin)) + fMin;
            }
            else
            {
                fMid = fMin - (hue * (fMax - fMin));
            }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);

            switch (iSextant)
            {
                case 1:
                    return Color.FromArgb(alpha, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(alpha, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(alpha, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(alpha, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(alpha, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(alpha, iMax, iMid, iMin);
            }
        }

    }
}
