using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Steg
{
    public class LSBData
    {
        // The bitmap of the image
        public Bitmap bmp;

        // Just the bitmap data
        private BitmapData bmpDat;

        // Memory pointer to the start of image data
        private IntPtr bmpPtr;

        // The image data, either modified or unmodified
        public byte[] values;
        int bytes;

        // The LSB data of the image
        public byte[] LSBs { get; set; }

        // The file type and default extension of the LSB information
        public string MIME { get; set; }
        public string extension { get; set; }

        #region Functions image handling
        public void openImg(string filename)
        {
            if (File.Exists(filename))
            {
                // Load the bitmap
                bmp = new Bitmap(filename);

                // Lock the bitmap's bits
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                bmpDat = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

                // Get the address of the first line
                bmpPtr = bmpDat.Scan0;

                // Move the bitmap data into the byte array
                bytes = Math.Abs(bmpDat.Stride) * bmp.Height;
                values = new byte[bytes];
                Marshal.Copy(bmpPtr, values, 0, bytes);
            }
        }

        public void closeImg()
        {
            // Copy the RGB values back to the bitmap & unlock
            Marshal.Copy(values, 0, bmpPtr, bytes);
            bmp.UnlockBits(bmpDat);
        }
        #endregion

        public void determineLSBs()
        {
            // Declare bit array and byte array
            BitArray bits = new BitArray(bytes / 8);
            for (int i = 0; i < bits.Length; i++)
            {
                // Add the LSB to bitArray
                bits[i] = (values[i] & 1) != 0;
            }
            // Copy the shifted bits from the image into the LSBs array
            LSBs = new byte[bytes / 8];
            bits.CopyTo(LSBs, 0);
        }

        public void determineMIME()
        {
            // Use mime assistant to determine file type and extension
            // Will not function properly if LSBs are invalid or null
            MIME = MIMEAssistant.GetMIMEType(LSBs);
            extension = MIMEAssistant.GetDefaultExtension(MIME);
        }
    }
}
