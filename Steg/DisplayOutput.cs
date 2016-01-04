using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Steg
{
    public partial class DisplayOutput : Form
    {
        string mime;
        byte[] outputData;

        public DisplayOutput(string outputStr = null, byte[] _outputData = null, bool trim = false)
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



                mime = MIMEAssistant.GetMIMEType(outputData);

                fileType.Text = "File type recognized as: " + mime + " | " + MIMEAssistant.GetDefaultExtension(mime) + " file.";

                if (mime == "application/octet-stream")
                {
                    fileType.Text = "File type not recognized.";
                }
                else if (trim)
                {
                    outputData = MIMEAssistant.Cut(outputData);
                }
                fileSize.Text = "Bytes: " + outputData.Length;
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