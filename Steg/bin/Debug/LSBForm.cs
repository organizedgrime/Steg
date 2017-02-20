using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Steg
{
    public partial class LSBForm : Form
    {
        LSBData lsb;

        public LSBForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

            lsb = new LSBData();
            string initialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            txtWriteImage.Text = initialPath;
            txtWriteDir.Text = initialPath;
            txtSecretFile.Text = initialPath;

            txtReadImage.Text = initialPath + "\\output.png";
            txtReadDir.Text = initialPath;
        }
        int getMaxBytes(string filename)
        {
            List<string> imageTypes = new List<string>() { ".jpg", ".jpeg", ".png", ".tiff" };
            if (File.Exists(filename) && imageTypes.Contains(Path.GetExtension(filename)))
            {
                Image img = Image.FromFile(filename);
                return ((img.Width * img.Height * 3) / 8);
            }
            return 0;
        }

        #region Write Form
        private void fileChooser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooserDialog = new OpenFileDialog())
            {
                fileChooserDialog.Filter = "PNG Files (.png)|*.png";
                fileChooserDialog.InitialDirectory = txtWriteImage.Text;
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtWriteImage.Text = fileChooserDialog.FileName;

                    // Display how much data you can input
                    lblSecretBytes.Text = "Max Bytes: " + getMaxBytes(txtWriteImage.Text);
                }
            }
        }

        private void folderChooser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtWriteDir.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtWriteImage.Text) && Directory.Exists(txtWriteDir.Text))
            {
                byte[] secret = cbxEmbedFile.Checked ? File.ReadAllBytes(txtSecretFile.Text) : Encoding.ASCII.GetBytes(txtSecretMessage.Text);
                if (secret.Length > getMaxBytes(txtWriteImage.Text))
                    MessageBox.Show("This image does not have enough room to store that much data");
                else
                    writeLSB(secret);
                /*
                if (cbxEmbedFile.Checked && File.Exists(txtSecretFile.Text))
                {
                    if (new FileInfo(txtSecretFile.Text).Length <= getMaxBytes(txtWriteImage.Text))
                    {
                        writeLSB(File.ReadAllBytes(txtSecretFile.Text));
                        MessageBox.Show("Writing Completed");
                    }
                    else
                    {
                        MessageBox.Show("File selected is too large to embed.");
                    }
                }
                else
                {
                    if (txtSecretMessage.Text.Length <= getMaxBytes(txtWriteImage.Text))
                    {
                        writeLSB(Encoding.ASCII.GetBytes(txtSecretMessage.Text));
                        MessageBox.Show("Writing Completed");
                    }
                    else
                    {
                        MessageBox.Show("Message input is too large to embed.");
                    }
                }
                */
            }
            else
            {
                MessageBox.Show("Invalid Folder or File");
            }
        }
        #endregion

        #region Read Form
        private void btnReadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooserDialog = new OpenFileDialog() { Filter = "PNG Files (.png)|*.png" })
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                    txtReadImage.Text = fileChooserDialog.FileName;
        }
        private void btnSecretFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooserDialog = new OpenFileDialog())
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                    txtSecretFile.Text = fileChooserDialog.FileName;
        }
        private void btnReadDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog embedOutputFolder = new FolderBrowserDialog())
                if (embedOutputFolder.ShowDialog() == DialogResult.OK)
                    txtReadDir.Text = embedOutputFolder.SelectedPath;
        }
        private void cbxEmbedFile_CheckedChanged(object sender, EventArgs e)
        {
            // When checked or unchecked, switch between the file input and text input
            txtSecretMessage.Visible ^= true;
            lblSecretMessage.Visible ^= true;
            btnSecretFile.Visible ^= true;
            lblSecretFile.Visible ^= true;
            txtSecretFile.Visible ^= true;
        }
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            readLSB(txtReadImage.Text);
        }
        #endregion

        #region Read and write LSB
        void writeLSB(byte[] byteMsg)
        {
            lsb.openImg(txtWriteImage.Text);

            if (cbxWriteMarker.Checked)
            {
                // The endmarker is "LSB" in ascii
                byte[] endMarker = { 0x4c, 0x53, 0x42 };

                // Resize the message array and insert the endmarker values into it
                Array.Resize(ref byteMsg, byteMsg.Length + 3);
                Array.Copy(endMarker, 0, byteMsg, byteMsg.Length - 3, 3);
            }

            BitArray bitMsg = new BitArray(byteMsg);

            for (int i = 0; i < bitMsg.Length; i++)
            {
                // Only change the value in the image if it's different from the value in our bit message
                lsb.values[i] = (byte)((lsb.values[i] & ~1) | Convert.ToInt32(bitMsg[i]));
            }

            lsb.closeImg();

            // Save the image and dispose of the bitmap
            lsb.bmp.Save(txtWriteDir.Text + "\\output.png");
            lsb.bmp.Dispose();
        }

        void readLSB(string filename)
        {
            lsb.openImg(filename);
            lsb.closeImg();

            // Determine the LSBs of the image data stored
            lsb.determineLSBs();

            // If the trim checkbox is checked, trim the data
            if (cbxReadMarker.Checked)
            {
                lsb.LSBs = MIMEAssistant.Cut(lsb.LSBs);
            }

            // Determine the MIME of the hidden data
            lsb.determineMIME();

            // Display file information if file is recognized
            if (lsb.MIME != "application/octet-stream")
            {
                MessageBox.Show("Filetype recognized as " + lsb.MIME + " | " + lsb.extension);
            }

            // Write the file out
            File.WriteAllBytes(txtReadDir.Text + "\\embedded" + lsb.extension, lsb.LSBs);
            MessageBox.Show("File Written to directory as \"embedded" + lsb.extension + "\"");

            lsb.bmp.Dispose();
        }

        #endregion
    }
}