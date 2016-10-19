using System;
using System.Text;
using System.Windows.Forms;

namespace Steg
{
    public partial class DisplayOutput : Form
    {
        public string mime, filetype;
        public byte[] outputData;
        public DisplayOutput(byte[] _outputData, bool str)
        {
            InitializeComponent();

            // Transfer the temporary variable into the class level one.
            outputData = _outputData;

            if (str)
            {
                outputText.Text = Encoding.Default.GetString(outputData);
            }
            else
            {
                // Change to the file output GUI
                outputText.Visible = false;
                copyButton.Visible = false;
                fileSize.Visible = true;
                fileType.Visible = true;
                writeEmbeddedButton.Visible = true;
                embeddedFolderChooser.Visible = true;
                embeddedOutputDirectory.Visible = true;

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
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputText.Text);
        }

        private void writeEmbeddedButton_Click(object sender, EventArgs e)
        {
            // Write the file out
            System.IO.File.WriteAllBytes(embeddedOutputDirectory.Text + "\\embedded" + MIMEAssistant.GetDefaultExtension(mime), outputData);
            MessageBox.Show("File Written to directory as \"embedded" + MIMEAssistant.GetDefaultExtension(mime) + "\"");
        }

        private void embeddedFolderChooser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog embedOutputFolder = new FolderBrowserDialog())
            {
                if (embedOutputFolder.ShowDialog() == DialogResult.OK)
                {
                    embeddedOutputDirectory.Text = embedOutputFolder.SelectedPath;
                }
            }
        }
    }
}