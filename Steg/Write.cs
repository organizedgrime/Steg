using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steg
{
    public partial class Write : Form
    {
        public Write()
        {
            InitializeComponent();
        }

        private void retrieveInput_Click(object sender, EventArgs e)
        {
            Program.writeLSB(this.filename.Text, this.outputDirectory.Text, this.message.Text);
            MessageBox.Show("Writing completed.");
        }

        private void filename_TextChanged(object sender, EventArgs e)
        {
            this.maxChars.Text = "Max Chars: " + Program.getMaxCharCount(new Bitmap(this.filename.Text));
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
