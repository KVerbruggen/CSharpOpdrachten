using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine2
{
    [DefaultEvent("Click")]
    public partial class ButtonOperator : UserControl
    {
        // Child button events get propagated to this class.
        // Based on: https://stackoverflow.com/questions/32264298/how-to-send-all-events-of-a-child-control-to-its-parent-control-custom-control
        public delegate void ButtonClickHandler(object sender, EventArgs e);
        public new event EventHandler Click;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        public override string Text
        {
            get { return button.Text; }
            set { button.Text = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        public new System.Drawing.Size Size
        {
            get { return base.Size; }
            set { base.Size = value; button.Size = value; }
        }

        public Operator Operator { get; set; }

        public ButtonOperator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}
