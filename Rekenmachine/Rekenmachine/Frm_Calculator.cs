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

        #region field declarations

        private Formula fullFormula;
        private Formula subFormula = new Formula();

        private double? currentInput = null;
        private int currentInputIndex = 1;

        private List<Formula> history = new List<Formula>();

        private bool overwroteLastResult = true;

        #endregion

        #region Constructor
        public Frm_Calculator()
        {
            InitializeComponent();
            fullFormula = subFormula;
        }
        #endregion

        #region updaters

        private void UpdateUI()
        {
            tbInput.Text = currentInput.ToString();
            tbFormula.Text = subFormula.ToString(true);
            lbHistory.Items.Clear();
            foreach (Formula f in history)
            {
                lbHistory.Items.Add(f);
            }
            lbHistory.Refresh();
        }

        #endregion

        #region methods

        private void SaveInput(Formula formula, int inputIndex, double input)
        {
            formula.SetInput(inputIndex, input);
            currentInput = null;
        }

        private void InputNumber(int input)
        {
            if (currentInputIndex == 2)
            {
                currentInputIndex = 3;
            }

            if (currentInput == 0)
            {
                currentInput = input;
            }
            else
            {
                currentInput = Double.Parse(currentInput.ToString() + input.ToString());
            }
            tbInput.Text = currentInput.ToString();
            UpdateUI();
        }

        private void InputOperator(Operator op)
        {
            Double input;
            if (currentInputIndex == 3)
            {
                Submit();
                Formula lastFormula = history[history.Count - 1];
                if (lastFormula.Answer != null)
                {
                    input = (Double)lastFormula.Answer;
                    currentInputIndex = 1;
                    SaveInput(subFormula, currentInputIndex, (Double)input);
                    subFormula.Operator = op;
                }
                else
                {
                    ClearEntry();
                }
                currentInputIndex = 3;
            }
            else if(currentInputIndex == 2)
            {
                subFormula.Operator = op;
            }
            else
            {
                if (Double.TryParse(tbInput.Text, out input))
                {
                    SaveInput(subFormula, currentInputIndex, (Double)input);
                    subFormula.Operator = op;
                }
                else
                {
                    ClearEntry();
                }
            }
            currentInputIndex = 2;
            UpdateUI();
        }

        private void Submit()
        {
            if (currentInputIndex == 1 || currentInputIndex == 2)
            {
                if (currentInput == null)
                {
                    // TO-DO: Repeat previous
                }
                else
                {
                    SaveInput(subFormula, 1, (Double)currentInput);
                    fullFormula = subFormula;
                }
            }
            else if(currentInputIndex == 3)
            {
                double input;
                if (Double.TryParse(tbInput.Text, out input))
                {
                    SaveInput(subFormula, 2, input);
                }
                else
                {
                    ClearEntry();
                }
            }
            fullFormula.Calculate();
            if (fullFormula.ToString() != "")
            {
                history.Add(fullFormula);
            }
            if (fullFormula.Answer != null && !Double.IsInfinity((Double)fullFormula.Answer) && !Double.IsNaN((Double)fullFormula.Answer))
            {
                currentInput = (Double)fullFormula.Answer;
            }
            subFormula = new Formula();
            fullFormula = subFormula;
            ClearFormula();
        }

        private void ClearEntry()
        {
            currentInput = null;
            UpdateUI();
        }

        private void ClearFormula()
        {
            subFormula = new Formula();
            fullFormula = subFormula;
            currentInputIndex = 1;
            UpdateUI();
        }
        private void Clear()
        {
            currentInput = null;
            ClearFormula();
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

        private void bt0_Click(object sender, EventArgs e)
        {
            InputNumber(0);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            InputNumber(1);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            InputNumber(2);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            InputNumber(3);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            InputNumber(4);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            InputNumber(5);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            InputNumber(6);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            InputNumber(7);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            InputNumber(8);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            InputNumber(9);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Addition);
        }

        private void btSubtract_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Subtraction);
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Multiplication);
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Division);
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void btClearEntry_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #endregion

    }
}
