using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Steg
{
    public partial class DisplayOutput : Form
    {
        public DisplayOutput(string outputStr = null, byte[] _outputData = null)
        {
            InitializeComponent();

            

            if (outputStr != null)
            {
                outputText.Text = outputStr;
            }
            else if (_outputData != null)
            {
                List<byte> outputData = _outputData.ToList();

                // Store a backup of the original array in case a file type is NOT recognized
                List<byte> outputDataCopy = outputData;

                string mime;

                outputText.Text = "File type not recognized.";
                // Cut down the bytes of the LSB bytes by 1 byte until a readable structure is found
                mime = MIMEAssistant.GetMIMEType(outputData.ToArray());

                while (mime != "application/octet-stream" && outputData.Count() > 1)
                {
                    mime = MIMEAssistant.GetMIMEType(outputData.ToArray());
                    outputData.RemoveAt(outputData.Count() - 1);
                }
                
                if(mime == "application/octet-stream")
                {
                    outputData = outputDataCopy;
                }
                else
                {
                    outputDataCopy.RemoveRange(outputData.Count() + 1, outputDataCopy.Count());
                    outputData = outputDataCopy;
                }


                outputText.Text = "File type recognized as: " + mime + " | " + MIMEAssistant.GetDefaultExtension(mime) + " file.";

                // Write the file out
                System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\embedded" + MIMEAssistant.GetDefaultExtension(mime), outputData.ToArray());
                MessageBox.Show("File Written to Desktop as \"embedded" + MIMEAssistant.GetDefaultExtension(mime) + "\"");
                MessageBox.Show(outputData.Count() + "");
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

        
    }
}
