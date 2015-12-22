using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steg
{
    public partial class DisplayOutput : Form
    {
        public DisplayOutput(string outputStr = null, byte[] outputData = null)
        {
            InitializeComponent();

            if (outputStr != null)
            {
                outputText.Text = outputStr;
            }
            else if (outputData != null)
            {
                // Store a backup of the original array in case a file type is NOT recognized
                byte[] outputDataCopy = outputData;


                string mime = null;

                // Cut down the bytes of the LSB bytes by 1 byte until a readable structure is found
                for (int i = 0; i < outputData.Length; i++)
                {
                    mime = MIMEAssistant.GetMIMEType(outputData);
                    if(mime != "application/octet-stream")
                    {
                        outputText.Text = "File type recognized as: " + mime + " | " + GetDefaultExtension(mime) + " file.";
                        break;
                    }
                    outputData = outputData.Take(outputData.Count() - 1).ToArray();
                }
                if(mime == "application/octet-stream")
                {
                    outputText.Text = "File type not recognized.";
                    // Restore the data to its original state, to be saved without file extension
                    outputData = outputDataCopy;
                }
                // Write the file out
                System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\embedded" + GetDefaultExtension(mime), outputData);
                MessageBox.Show("File Written to Desktop as \"embedded" + GetDefaultExtension(mime) + "\"");
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

        public static string GetDefaultExtension(string mimeType)
        {
            string result;
            Microsoft.Win32.RegistryKey key;
            object value;

            key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + mimeType, false);
            value = key != null ? key.GetValue("Extension", null) : null;
            result = value != null ? value.ToString() : string.Empty;

            return result;
        }
    }
}
