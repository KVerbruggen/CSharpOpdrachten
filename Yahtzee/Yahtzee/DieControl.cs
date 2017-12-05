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
        // Child button events get propagated to this class.
        // Based on: https://stackoverflow.com/questions/32264298/how-to-send-all-events-of-a-child-control-to-its-parent-control-custom-control
        public delegate void ButtonClickHandler(object sender, EventArgs e);
        public new event EventHandler Click;

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

        private void pictureBox_Click(object sender, EventArgs e)
        {
            checkBox.Checked = !checkBox.Checked;
        }
    }
}
