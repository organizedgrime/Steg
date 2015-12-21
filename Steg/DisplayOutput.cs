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
                outputText.Visible = true;
                outputText.Text = outputStr;
            }
            else if (outputData != null)
            {
                outputText.Visible = false;
                //TODO
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
    }
}
