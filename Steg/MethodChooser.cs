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
    public partial class MethodChooser : Form
    {
        public MethodChooser()
        {
            InitializeComponent();
        }

        private void methodDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selectMethodButton_Click(object sender, EventArgs e)
        {
            
            if (this.methodDropdown.Text == "LSB Write")
            {
                Write lsbwrite = new Write();
                lsbwrite.ShowDialog();
                this.Close();
            }
            else if (this.methodDropdown.Text == "LSB Read")
            {
                Read lsbread = new Read();
                lsbread.ShowDialog();
                this.Close();
            }
        }
    }
}
