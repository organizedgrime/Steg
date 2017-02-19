using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Steg
{
    public partial class DisplayOutput : Form
    {
        LSBData data;
        public DisplayOutput(LSBData _data)
        {
            InitializeComponent();
            data = _data;

            // Log ascii data
            foreach (byte b in data.values)
            {
                Debug.WriteLine(b);
            }

            // Determine the MIME and file extension of the ouput data
            data.determineLSBs();
            data.determineMIME();

            // Display file information if file is recognized
            if(data.MIME != "application/octet-stream")
            {
                lblFileInfo.Text = data.MIME + " | " + data.extension;
                lblFileBytes.Text = data.LSBs.Length + "";
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void btnFileOutput_Click(object sender, EventArgs e)
        {
            // Choose the folder to output the file
            using (FolderBrowserDialog embedOutputFolder = new FolderBrowserDialog())
            {
                if (embedOutputFolder.ShowDialog() == DialogResult.OK)
                {
                    txtFileOutput.Text = embedOutputFolder.SelectedPath;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // Write the file out
            System.IO.File.WriteAllBytes(txtFileOutput.Text + "\\embedded" + data.extension, data.LSBs);
            MessageBox.Show("File Written to directory as \"embedded" + data.extension + "\"");
        }
    }
}