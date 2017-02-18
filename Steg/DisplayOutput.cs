using System;
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

            // Determine the MIME and file extension of the ouput data
            data.determineLSBs();
            data.determineMIME();

            // Set the extension label
            lblFileInfoData.Text = data.MIME +" | " + data.extension;
            
            /*
            if (str)
            {
                outputText.Text = Encoding.Default.GetString(outputData);
            }
            else
            {
                // Get the default Desktop folder for writing.
                embeddedOutputDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                mime = MIMEAssistant.GetMIMEType(outputData);
                if (mime == "application/octet-stream")
                {
                    fileType.Text = "File type not recognized.";
                }
                else
                {
                    fileType.Text = "File type recognized as: " + mime + " | " + MIMEAssistant.GetDefaultExtension(mime) + " file.";
                }
                fileSize.Text = "Bytes: " + outputData.Length;
            }
            */
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