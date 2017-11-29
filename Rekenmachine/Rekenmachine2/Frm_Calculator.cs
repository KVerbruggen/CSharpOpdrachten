using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine2
{
    
    public partial class Frm_Calculator : Form
    {

        #region field declarations


        #endregion

        #region Constructor
        public Frm_Calculator()
        {
            InitializeComponent();
        }
        #endregion

        #region methods

        private void Submit()
        {
            // TO-DO
        }

        #endregion

        #region Event listeners

        private void Frm_Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                Submit();
            }
        }

        private void tbInput_KeyUp(object sender, KeyEventArgs e)
        {
            // TO-DO: Manual input
            switch (e.KeyData)
            {
                default:
                    break;
            }
        }

        #endregion

        private void btNumber_Click(object sender, EventArgs e)
        {
        }

        private void btOperator_Click(object sender, EventArgs e)
        {

        }

        private void btDot_Click(object sender, EventArgs e)
        {

        }
    }
}
