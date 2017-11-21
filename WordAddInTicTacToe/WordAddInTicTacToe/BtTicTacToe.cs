using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAddInTicTacToe
{
    public partial class BtTicTacToe : UserControl
    {
        // Child button events get propagated to this class.
        // Based on: https://stackoverflow.com/questions/32264298/how-to-send-all-events-of-a-child-control-to-its-parent-control-custom-control
        public delegate void ButtonClickHandler(object sender, EventArgs e);
        public new event EventHandler Click;

        public int[] Coordinates { get; private set; }
        public BtTicTacToe(int x, int y)
        {
            SetCoordinates(x, y);
            InitializeComponent();
        }

        public BtTicTacToe() : this(0, 0)
        {
        }

        public void SetCoordinates(int x, int y)
        {
            Coordinates = new int[2] { x, y };
        }

        public Button GetButton()
        {
            return (Button)this.Controls.Find("btTicTacToeCell", true)[0];
        }

        private void btTicTacToeCell_Click(object sender, EventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }
        }
    }
}
