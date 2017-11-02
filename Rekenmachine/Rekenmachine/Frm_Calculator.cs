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

        private bool overwroteLastResult = false;

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
            for (int i = 0; i < history.Count; i++)
            {
                if (lbHistory.Items.Count < i + 1)
                {
                    lbHistory.Items.Add(history[i]);
                }
                else
                {
                    if(lbHistory.Items[i] != history[i])
                    {
                        lbHistory.Items[i] = history[i];
                    }
                }
            }
            lbHistory.Refresh();
            lbHistory.TopIndex = lbHistory.Items.Count - 1;
        }

        private void EnableOperatorButtons()
        {
            btAdd.Enabled = true;
            btSubtract.Enabled = true;
            btMultiply.Enabled = true;
            btDivide.Enabled = true;
            btSqrt.Enabled = true;
            btSquare.Enabled = true;
            btInvolution.Enabled = true;
            btPercent.Enabled = true;
            btEuro.Enabled = true;
        }

        private void DisableOperatorButtons()
        {
            btAdd.Enabled = false;
            btSubtract.Enabled = false;
            btMultiply.Enabled = false;
            btDivide.Enabled = false;
            btSqrt.Enabled = false;
            btSquare.Enabled = false;
            btInvolution.Enabled = false;
            btPercent.Enabled = true;
            btEuro.Enabled = true;
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
            EnableOperatorButtons();

            if (currentInputIndex == 2)
            {
                currentInputIndex = 3;
            }

            if (currentInput == 0 || !overwroteLastResult)
            {
                currentInput = input;
                overwroteLastResult = true;
            }
            else
            {
                Double newInput;
                try
                {
                    newInput = Double.Parse(currentInput.ToString() + input.ToString());
                    currentInput = newInput;
                }
                catch (OverflowException)
                {
                    DisableOperatorButtons();
                }
                
            }
            UpdateUI();
        }

        private void InputOperator(Operator op)
        {
            // TO-DO: Vervang 'currentInputIndex' door algoritme om te bepalen of er een nieuwe Sub-formule moet worden aangemaakt.
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
                    SaveInput(subFormula, 1, (Double)input);
                }
                else
                {
                    SaveInput(subFormula, 1, 0);
                }
                subFormula.Operator = op;
            }
            currentInputIndex = 2;
            UpdateUI();
        }

        private void Submit(int? roundDecimals = null)
        {
            if (currentInputIndex == 1)
            {
                if (!overwroteLastResult)
                {
                    if (currentInput == null)
                    {
                        Clear();
                        return;
                    }
                    subFormula.SetInput(1, (Double)currentInput);
                    Formula lastFormula = (Formula)history[history.Count - 1];
                    dynamic lastFormulaInput2 = lastFormula.GetRawInput(2);
                    if (lastFormulaInput2 == null)
                    {
                        subFormula.SetInput(2, 0);
                    }
                    else
                    {
                        subFormula.SetInput(2, lastFormulaInput2);
                    }
                    subFormula.Operator = lastFormula.Operator;
                    fullFormula = subFormula;
                }
                else
                {
                    subFormula.SetInput(1, (Double)currentInput);
                    fullFormula = subFormula;
                }
            }
            else if(currentInputIndex == 3)
            {
                Double input;
                if (Double.TryParse(tbInput.Text, out input))
                {
                    subFormula.SetInput(2, input);
                }
                else
                {
                    ClearEntry();
                }
            }
            fullFormula.Calculate(roundDecimals);
            if (fullFormula.ToString() != "")
            {
                if (history.Count > 0)
                {
                    Formula lastFormula = history[history.Count - 1];
                    if (lastFormula.ToString(false) != fullFormula.ToString(false) || currentInputIndex == 3)
                    {
                        history.Add(fullFormula);
                    }
                }
                else
                {
                    history.Add(fullFormula);
                }
            }
            if (fullFormula.Answer != null && !Double.IsInfinity((Double)fullFormula.Answer) && !Double.IsNaN((Double)fullFormula.Answer))
            {
                currentInput = (Double)fullFormula.Answer;
            }
            subFormula = new Formula();
            fullFormula = subFormula;
            ClearFormula();
            overwroteLastResult = false;
        }

        private void ClearEntry()
        {
            currentInput = null;
            EnableOperatorButtons();
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
            ClearEntry();
            ClearFormula();
        }

        private void ClearCharacter()
        {
            if (overwroteLastResult)
            {
                String currentInputAsString = currentInput.ToString();
                if (currentInputAsString.Length > 1)
                {
                    currentInput = Double.Parse(currentInputAsString.Substring(0, currentInputAsString.Length - 1));
                }
                else if (currentInputAsString.Length == 1)
                {
                    currentInput = null;
                }
                UpdateUI();
            }
            else
            {
                ClearEntry();
            }
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

        private void btBackspace_Click(object sender, EventArgs e)
        {
            ClearCharacter();
        }

        private void btInvolution_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Involution);
        }

        private void btSquare_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Involution);
            subFormula.SetInput(2, 2);
            Submit();
        }

        private void btSqrt_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Involution);
            subFormula.SetInput(2, 0.5);
            Submit();
        }

        private void btPercent_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Division);
            subFormula.SetInput(2, 100);
            Submit();
        }

        private void btEuro_Click(object sender, EventArgs e)
        {
            InputOperator(Operator.Division);
            subFormula.SetInput(2, 100);
            Submit(2);
        }
    }
}
