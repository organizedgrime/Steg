using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Steg
{
    public partial class LSBForm : Form
    {
        public static string initialPath;
        public LSBForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

            initialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filename.Text = initialPath;
            filename2.Text = initialPath + "\\output.png";
            outputDirectory.Text = initialPath;
            fileInputFilename.Text = initialPath;
        }


        // Write Form

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
                        LSBFunctions.writeLSB(filename.Text, outputDirectory.Text, Convert.ToInt32(bitCount.Value), null, File.ReadAllBytes(fileInputFilename.Text), endMarkBool.Checked);
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
                        LSBFunctions.writeLSB(filename.Text, outputDirectory.Text, Convert.ToInt32(bitCount.Value), message.Text);
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


        // Read Form

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            LSBFunctions.readLSB(filename2.Text, Convert.ToInt32(bitCountRead.Value), concatBool.Checked, fileOutputBool.Checked, concatBool.Checked, trimBool.Checked);
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

        private void fileOutputBool_CheckedChanged(object sender, EventArgs e)
        {
            // Invert current values of relevant buttons
            concatBool.AutoCheck ^= true;
            trimBool.AutoCheck ^= true;
        }

        private void bitCount_ValueChanged(object sender, EventArgs e)
        {
            maxBytes.Text = "Max Bytes: " + getMaxBytes(filename.Text);
        }

        int getMaxBytes(string filename)
        {
            List<string> imageTypes = new List<string>() { ".jpg", ".jpeg", ".png", ".tiff" };
            if (File.Exists(filename) && imageTypes.Contains(Path.GetExtension(filename)))
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(filename);
                return Convert.ToInt32((img.Width * img.Height * 3) / 8 * bitCount.Value);
            }
            return 0;
        }
    }
}