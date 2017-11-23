using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class DieControl : UserControl
    {
        public Image Image
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public bool Checked
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }

        public DieControl()
        {
            InitializeComponent();
            groupBox.TabStop = false;
        }

        private void DieControl_Click(object sender, EventArgs e)
        {
            checkBox.Checked = !checkBox.Checked;
        }
    }
}
