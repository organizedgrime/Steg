using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
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
            txtInputFile.Text = initialPath;
            filename2.Text = initialPath + "\\output.png";
            txtOutputDir.Text = initialPath;
            txtSecretFile.Text = initialPath;
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
                fileChooserDialog.InitialDirectory = txtInputFile.Text;
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtInputFile.Text = fileChooserDialog.FileName;

                    // Display how much data you can input
                    lblSecretBytes.Text = "Max Bytes: " + getMaxBytes(txtInputFile.Text);
                }
            }
        }

        private void folderChooser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputDir.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void retrieveInput_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtInputFile.Text) && Directory.Exists(txtOutputDir.Text))
            {
                if (fileInputBool.Checked && File.Exists(txtSecretFile.Text))
                {
                    if (new FileInfo(txtSecretFile.Text).Length <= getMaxBytes(txtInputFile.Text))
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
                    if (txtSecretMessage.Text.Length <= getMaxBytes(txtInputFile.Text))
                    {
                        writeLSB(Encoding.ASCII.GetBytes(txtSecretMessage.Text));
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
            txtSecretMessage.Visible ^= true;
            lblSecretMessage.Visible ^= true;
            btnSecretFile.Visible ^= true;
            lblSecretFile.Visible ^= true;
            txtSecretFile.Visible ^= true;
        }

        private void fileInputButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooserDialog = new OpenFileDialog())
            {
                if (fileChooserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSecretFile.Text = fileChooserDialog.FileName;
                }
            }
        }
        #endregion

        #region Read and write LSB
        void readLSB(string filename)
        {
            lsb.openImg(filename);
            lsb.closeImg();

            produceOuput(lsb.bytes);
        }

        void writeLSB(byte[] byteMsg)
        {
            lsb.openImg(txtInputFile.Text);

            if (endMarkBool.Checked)
            {
                Array.Resize(ref byteMsg, byteMsg.Length + 3);
                byteMsg[byteMsg.Length - 3] = 0x4c;
                byteMsg[byteMsg.Length - 2] = 0x53;
                byteMsg[byteMsg.Length - 1] = 0x42;
            }

            BitArray bitMsg = new BitArray(byteMsg);

            for (int i = 0; i < bitMsg.Length; i++)
            {
                lsb.bytes[i] = (byte)((lsb.bytes[i] & ~1) | Convert.ToInt32(bitMsg[i]));
            }

            lsb.closeImg();
            lsb.saveImg(txtOutputDir.Text);
        }
        #endregion

        #region Output read data

        void produceOuput(byte[] outputData)
        {
            new DisplayOutput(lsb).Show();
        }
        #endregion
    }
}