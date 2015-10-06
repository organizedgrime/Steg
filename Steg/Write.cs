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
            if(File.Exists(this.filename.Text))
            {
                this.maxChars.Text = "Max Chars: " + Program.getMaxCharCount(new Bitmap(this.filename.Text));
            }
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
        }

        private void fileChooserDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        OpenFileDialog fileChooserDialog = new OpenFileDialog();

        private void fileChooser_Click(object sender, EventArgs e)
        {
            if (fileChooserDialog.ShowDialog() == DialogResult.OK)
            {
                this.filename.Text = fileChooserDialog.FileName;
            }
        }


        FolderBrowserDialog folderChooserDialog = new FolderBrowserDialog();
        private void folderChooser_Click(object sender, EventArgs e)
        {
            if(folderChooserDialog.ShowDialog() == DialogResult.OK)
            {
                this.outputDirectory.Text = folderChooserDialog.SelectedPath;
            }
        }
    }
}
