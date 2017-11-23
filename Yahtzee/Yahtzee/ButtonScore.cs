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
    public partial class ButtonScore : UserControl
    {
        // Child button events get propagated to this class.
        // Based on: https://stackoverflow.com/questions/32264298/how-to-send-all-events-of-a-child-control-to-its-parent-control-custom-control
        public delegate void ButtonClickHandler(object sender, EventArgs e);
        public new event EventHandler Click;

        public ScoreType ScoreType { get; set; }

        // Attributes necessary to show 'Text'-property to Windows Forms Designer Property View.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        public override string Text
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }

        public ButtonScore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}
