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
            InitializeComponent();
        }


        // Write Form
        OpenFileDialog fileChooserDialog = new OpenFileDialog();

        private void fileChooser_Click(object sender, EventArgs e)
        {
            fileChooserDialog.Filter = "PNG Files (.png)|*.png";
            if (fileChooserDialog.ShowDialog() == DialogResult.OK)
            {
                filename.Text = fileChooserDialog.FileName;

                // Display how much text you can enter
                Bitmap bmp = new Bitmap(filename.Text);
                maxChars.Text = "Max Chars: " + ((bmp.Width * bmp.Height) / 8);
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
            LSBFunctions.writeLSB(filename.Text, outputDirectory.Text, message.Text);
            MessageBox.Show("Writing Completed");
        }


        // Read Form

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            LSBFunctions.readLSB(filename2.Text);
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


    }
}
