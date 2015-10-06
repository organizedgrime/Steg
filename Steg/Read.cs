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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            Program.readLSB(this.filename.Text);
        }

        OpenFileDialog fileChooserDialog = new OpenFileDialog();

        private void fileChooser_Click(object sender, EventArgs e)
        {
            if (fileChooserDialog.ShowDialog() == DialogResult.OK)
            {
                this.filename.Text = fileChooserDialog.FileName;
            }
        }
    }
}
