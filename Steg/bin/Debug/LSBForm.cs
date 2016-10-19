using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Steg
{
    public partial class LSBForm : Form
    {
        Bitmap bmp;
        byte[] rgbValues;
        BitmapData bmpData;
        int bytes;
        IntPtr ptr;

        public LSBForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

            String initialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filename.Text = initialPath;
            filename2.Text = initialPath + "\\output.png";
            outputDirectory.Text = initialPath;
            fileInputFilename.Text = initialPath;
        }
        int getMaxBytes(string filename)
        {
            List<string> imageTypes = new List<string>() { ".jpg", ".jpeg", ".png", ".tiff" };
            if (File.Exists(filename) && imageTypes.Contains(Path.GetExtension(filename)))
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(filename);
                return Convert.ToInt32((img.Width * img.Height * 3) / 8);
            }
            return 0;
        }

        #region Write Form
        private void fileChooser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooserDialog = new OpenFileDialog())
            {
                fileChooserDialog.Filter = "PNG Files (.png)|*.png";
                fileChooserDialog.InitialDirectory = filename.Text;
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                {
                    filename.Text = fileChooserDialog.FileName;

                    // Display how much data you can input
                    maxBytes.Text = "Max Bytes: " + getMaxBytes(filename.Text);
                }
            }
        }

        private void folderChooser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputDirectory.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void retrieveInput_Click(object sender, EventArgs e)
        {
            if (File.Exists(filename.Text) && Directory.Exists(outputDirectory.Text))
            {
                if (fileInputBool.Checked && File.Exists(fileInputFilename.Text))
                {
                    if (new FileInfo(fileInputFilename.Text).Length <= getMaxBytes(filename.Text))
                    {
                        writeLSB(File.ReadAllBytes(fileInputFilename.Text));
                        MessageBox.Show("Writing Completed");
                    }
                    else
                    {
                        MessageBox.Show("File selected is too large to embed.");
                    }
                }
                else
                {
                    if (message.Text.Length <= getMaxBytes(filename.Text))
                    {
                        writeLSB(Encoding.ASCII.GetBytes(message.Text));
                        MessageBox.Show("Writing Completed");
                    }
                    else
                    {
                        MessageBox.Show("Message input is too large to embed.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Folder or File");
            }
        }
        #endregion

        #region Read Form
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            readLSB(filename2.Text);
        }

        private void fileChooser2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooserDialog = new OpenFileDialog())
            {
                fileChooserDialog.Filter = "PNG Files (.png)|*.png";
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                {
                    filename2.Text = fileChooserDialog.FileName;
                }
            }
        }

        private void fileInputBool_CheckedChanged(object sender, EventArgs e)
        {
            // When checked or unchecked, switch between the file input and text input
            message.Visible ^= true;
            MessageLabel.Visible ^= true;
            fileInputButton.Visible ^= true;
            fileInputLabel.Visible ^= true;
            fileInputFilename.Visible ^= true;
            endMarkBool.Visible ^= true;
        }

        private void fileInputButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooserDialog = new OpenFileDialog())
            {
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                {
                    fileInputFilename.Text = fileChooserDialog.FileName;
                }
            }
        }
        #endregion

        #region Read and write LSB
        void readLSB(string filename)
        {
            openImg(filename);

            closeImg();
            bmp.Dispose();

            if (!fileOutputCheckbox.Checked)
            {
                // Copy the byte[] into a char[] and into a string
                char[] chars = new char[rgbValues.Length / sizeof(char)];
                Buffer.BlockCopy(rgbValues, 0, chars, 0, rgbValues.Length);
                string str = new string(chars);

                // Cut the gibberish if the user wants you to.
                if (trimBool.Checked)
                {
                    String tmp = "";
                    foreach (char c in str)
                    {
                        // Check if each character is in the desired ascii range
                        if (c >= 0x20 && c <= 0x7F)
                        {
                            tmp += c;
                        }
                    }
                    str = tmp;
                }
                MessageBox.Show(str);
                rgbValues = Encoding.ASCII.GetBytes(str);
            }
            produceOuput();
        }

        void writeLSB(byte[] bytes)
        {
            openImg(filename.Text);
            byte[] byteMsg = bytes;

            if (endMarkBool.Checked)
            {
                Array.Resize(ref byteMsg, byteMsg.Length + 3);
                byteMsg[byteMsg.Length - 3] = 0x4c;
                byteMsg[byteMsg.Length - 2] = 0x53;
                byteMsg[byteMsg.Length - 1] = 0x42;
            }

            BitArray bitMsg = new BitArray(byteMsg);

            for (int i = 0; i < rgbValues.Length; i++)
            {
                // Test to see if we've written all of bitMsg
                if (i < bitMsg.Length)
                {
                    // If the intended message is different from the preexisting bit, write to it.
                    if (bitMsg[i] ^ Convert.ToBoolean(rgbValues[i]))
                    {
                        //(n & ~1) | b
                        rgbValues[i] = (byte)((rgbValues[i]) | Convert.ToInt32(bitMsg[i]));
                    }
                }
                else
                {
                    break;
                }
            }

            closeImg();

            // Save the modified image.
            bmp.Save(outputDirectory.Text + "\\output.png");
            bmp.Dispose();
        }
        #endregion

        #region Output read data

        void produceOuput()
        {
            if(trimBool.Checked)
                rgbValues = MIMEAssistant.Cut(rgbValues);

            new DisplayOutput(rgbValues, !fileOutputCheckbox.Checked).Show();
        }

        #endregion

        #region Functions for opening and closing images
        public void openImg(string filename)
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

        public void closeImg()
        {
            // Copy the RGB values back to the bitmap & unlock
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
        }
        #endregion
    }
}