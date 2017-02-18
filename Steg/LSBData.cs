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
        private Bitmap bmp;

        // Just the bitmap data
        private BitmapData bmpDat;

        // Memory pointer to the start of image data
        private IntPtr bmpPtr;

        // The image data, either modified or unmodified
        public byte[] bytes;

        // The LSB data of the image
        public byte[] LSBs;

        // The file type and default extension of the LSB information
        public string MIME { get; set; }
        public string extension { get; set; }

        #region Functions image handling
        public void openImg(string filename)
        {
            if (File.Exists(filename))
            {
                bmp = new Bitmap(filename);
                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                bmpDat = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

                // Get the address of the first line.
                bmpPtr = bmpDat.Scan0;

                // Move the bitmap data into the byte array
                bytes = new byte[Math.Abs(bmpDat.Stride) * bmp.Height];
                Marshal.Copy(bmpPtr, bytes, 0, bytes.Length);
            }
        }

        public void closeImg()
        {
            // Copy the RGB values back to the bitmap & unlock
            Marshal.Copy(bytes, 0, bmpPtr, bytes.Length);
            bmp.UnlockBits(bmpDat);
        }

        public void saveImg(string directory)
        {
            // Save the modified image.
            bmp.Save(directory + "\\output.png");
            bmp.Dispose();
        }
        #endregion

        public void determineLSBs()
        {
            // Declare bit array and byte array
            BitArray msg = new BitArray(bytes.Length / 8);
            byte[] msgBytes = new byte[bytes.Length];

            for (int i = 0; i < msg.Length; i++)
            {
                // Add the LSB to bitArray
                msg[i] = (bytes[i] & (1 << 7)) != 0;
            }
            // Copy the bits from the image into the byte[]
            msg.CopyTo(msgBytes, 0);

            // Return byte array of LSBs
            LSBs = msgBytes;
        }

        public void determineMIME()
        {
            MIME = MIMEAssistant.GetMIMEType(LSBs);
            extension = MIMEAssistant.GetDefaultExtension(MIME);
        }
    }
}
