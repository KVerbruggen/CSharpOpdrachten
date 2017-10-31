using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    
    public partial class Frm_Calculator : Form
    {
        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            submitFormula();
        }

        private void Frm_Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                submitFormula();
            }
        }

        private void tbCalculation_KeyUp(object sender, KeyEventArgs e)
        {
            // TO-DO: Manual input
            switch (e.KeyData)
            {
                default:
                    break;
            }
        }

        private void submitFormula()
        {
            tbCalculation.Text = "7+3";
            tbCalculation.Text = Calculator.Calculate(tbCalculation.Text).ToString();
        }

        private bool inputAllowed(string formula, char c)
        {
            int number;
            bool isNumber = Int32.TryParse(c.ToString(), out number);
            char previousCharacter = formula[formula.Length - 1];
            bool previousIsNumber = Int32.TryParse(c.ToString(), out number);
            if (isNumber)
            {
                if (previousIsNumber)
                {
                    return true;
                }
                switch (previousCharacter)
                {
                    case ')':
                        return false;
                    default:
                        return true;
                }
            }
            else
            {
                switch (c)
                {
                    case '(':
                        return ("+-×÷".Contains(previousCharacter));
                    default:
                        return previousIsNumber;
                }
            }

        }

        private void btClearEntry_Click(object sender, EventArgs e)
        {
            tbCalculation.Text = "0";
        }
    }
}
