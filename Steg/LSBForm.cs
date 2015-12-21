using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steg
{
    public partial class LSBForm : Form
    {
        public LSBForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

            string initialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filename.Text = initialPath;
            filename2.Text = initialPath + "\\output.png";
            outputDirectory.Text = initialPath;
            fileInputFilename.Text = initialPath;

        }


        // Write Form
        OpenFileDialog fileChooserDialog = new OpenFileDialog();

        private void fileChooser_Click(object sender, EventArgs e)
        {
            fileChooserDialog.Filter = "PNG Files (.png)|*.png";
            fileChooserDialog.InitialDirectory = filename.Text;
            if (fileChooserDialog.ShowDialog() == DialogResult.OK)
            {
                filename.Text = fileChooserDialog.FileName;

                // Display how much text you can enter
                Bitmap bmp = new Bitmap(filename.Text);
                maxChars.Text = "Max Chars: " + ((bmp.Width * bmp.Height * 3) / 8);
            }
        }

        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        private void folderChooser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void retrieveInput_Click(object sender, EventArgs e)
        {
            if(File.Exists(filename.Text) && Directory.Exists(outputDirectory.Text))
            {
                if (fileInputBool.Checked && File.Exists(fileInputFilename.Text))
                {
                    LSBFunctions.writeLSB(filename.Text, outputDirectory.Text, null, File.ReadAllBytes(fileInputFilename.Text));
                }
                else
                {
                    LSBFunctions.writeLSB(filename.Text, outputDirectory.Text, message.Text, null);
                }
                MessageBox.Show("Writing Completed");
            }
            else
            {
                MessageBox.Show("Invalid Folder or File");
            }
        }


        // Read Form

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            LSBFunctions.readLSB(filename2.Text, concatBool.Checked, fileOutputBool.Checked);
        }

        OpenFileDialog fileChooserDialog2 = new OpenFileDialog();

        private void fileChooser2_Click(object sender, EventArgs e)
        {
            fileChooserDialog2.Filter = "PNG Files (.png)|*.png";
            if (fileChooserDialog2.ShowDialog() == DialogResult.OK)
            {
                filename2.Text = fileChooserDialog2.FileName;
            }
        }

        private void fileInputBool_CheckedChanged(object sender, EventArgs e)
        {
            // When checked or unchecked, switch between the file input and text input
                message.Visible ^= true;
                MessageLabel.Visible ^= true;
                maxChars.Visible ^= true;
                fileInputButton.Visible ^= true;
                fileInputLabel.Visible ^= true;
                fileInputFilename.Visible ^= true;
        }

        OpenFileDialog fileChooserDialog3 = new OpenFileDialog();

        private void fileInputButton_Click(object sender, EventArgs e)
        {
            if (fileChooserDialog3.ShowDialog() == DialogResult.OK)
            {
                fileInputFilename.Text = fileChooserDialog3.FileName;
            }
        }

        private void fileOutputBool_CheckedChanged(object sender, EventArgs e)
        {
            // Invert current values of relevant buttons
            concatBool.Checked ^= true;
            concatBool.AutoCheck ^= true;
        }
    }
}
