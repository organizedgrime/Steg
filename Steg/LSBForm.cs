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
            //filename2.Text = initialPath + "\\output.png";
            outputDirectory.Text = initialPath;
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
                LSBFunctions.writeLSB(filename.Text, outputDirectory.Text, brightnessBar.Value);
            }
            else
            {
                MessageBox.Show("Invalid Folder or File");
            }
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
    }
}