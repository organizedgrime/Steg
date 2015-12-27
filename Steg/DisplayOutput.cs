using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Steg
{
    public partial class DisplayOutput : Form
    {
        string mime;
        byte[] outputData;

        public DisplayOutput(string outputStr = null, byte[] _outputData = null)
        {
            InitializeComponent();

            // Transfer the temporary variable into the class level one.
            outputData = _outputData;

            if (outputStr != null)
            {
                outputText.Text = outputStr;
            }
            else if (outputData != null)
            {
                // Change to the file output GUI
                outputText.Visible = false;
                copyButton.Visible = false;
                fileType.Visible = true;
                writeEmbeddedButton.Visible = true;
                embeddedFolderChooser.Visible = true;
                embeddedOutputDirectory.Visible = true;

                // Get the default Desktop folder for writing.
                string initialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                embeddedOutputDirectory.Text = initialPath;


                fileType.Text = "File type not recognized.";
                mime = MIMEAssistant.GetMIMEType(outputData);
                if(mime != "application/octet-stream")
                {
                    fileType.Text = "File type recognized as: " + mime + " | " + MIMEAssistant.GetDefaultExtension(mime) + " file.";
                }
            }
            else
            {
                // This should never happen. If it does, you are calling this function incorrectly.
                outputText.Text = "PROGRAM ERROR: Data is null.";
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
    }
}
