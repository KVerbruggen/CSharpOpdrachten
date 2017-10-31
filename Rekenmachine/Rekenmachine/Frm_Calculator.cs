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
        bool deletedResult = false;

        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void submit(object sender, EventArgs e)
        {
            submit();
        }

        private void Frm_Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                submit();
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

        private void submit()
        {
            if (!deletedResult)
            {
                Calculator.Repeat();
            }
            else
            {
                double input;
                if (Double.TryParse(tbInput.Text, out input))
                {
                    Calculator.Number2 = input;
                    Calculator.Calculate();
                }
            }
            deletedResult = false;
            tbCalculation.Text = Calculator.Number1 + " " + Calculator.LastOp + " " + Calculator.Number2 + " = ";
            tbInput.Text = Calculator.LastResult.ToString();
        }

        private void inputNumber(int input)
        {
            if (tbInput.Text == "0" || !deletedResult)
            {
                tbInput.Text = String.Empty;
                deletedResult = true;
            }
            tbInput.Text += input;
        }

        private void inputOperator(char op)
        {
            if (tbInput.Text == String.Empty)
            {
                Calculator.Number1 = Calculator.LastResult;
                Calculator.LastOp = op;
                deletedResult = true;
            }
            else
            {
                double input;
                if (Double.TryParse(tbInput.Text, out input))
                {
                    Calculator.Number1 = input;
                }
                Calculator.LastOp = op;
            }
            tbCalculation.Text = Calculator.Number1 + " " + Calculator.LastOp + " ";
            tbInput.Text = String.Empty;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearEntry();
            tbCalculation.Text = String.Empty;
            Calculator.Clear();
        }
        private void btClearEntry_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void ClearEntry()
        {
            deletedResult = true;
            tbInput.Text = "0";
        }

        private void inputNumber(object sender, EventArgs e)
        {
            string str_input = (sender as Button).Text;
            int input;
            if (Int32.TryParse(str_input, out input))
            {
                inputNumber(input);
            }
        }

        private void inputOperator(object sender, EventArgs e)
        {
            string str_input = (sender as Button).Text;
            char input = str_input[0];
            if (Calculator.operators.Contains(input))
            {
                inputOperator(input);
            }
        }

        private void btBackspace_Click(object sender, EventArgs e)
        {
            int inputlength = tbInput.Text.Length;
            if (inputlength > 0)
            {
                tbInput.Text = tbInput.Text.Substring(0, inputlength - 1);
            }
        }
    }
}
