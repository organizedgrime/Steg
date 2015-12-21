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
                //TODO
                string mime = MIMEAssistant.GetMIMEType(outputData);
                outputText.Text = "File type: " + mime + " | " + GetDefaultExtension(mime) + " file.";
                System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "output." + GetDefaultExtension(mime), outputData);
                MessageBox.Show("File Written to Desktop");
            }
            else
            {
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
