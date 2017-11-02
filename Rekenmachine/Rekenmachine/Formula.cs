using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    public enum Operator
    {
        Addition = '+',
        Subtraction = '-',
        Multiplication = '×',
        Division = '÷',
        Involution = '^'
    };

    class Formula
    {

        #region Automatic Properties

        private double? Input1Number { get; set; }
        private double? Input2Number { get; set; }

        private Formula Input1Formula { get; set; }
        private Formula Input2Formula { get; set; }

        public Operator Operator { get; set; }

        public double? Answer { get; private set; }

        #endregion

        #region Constructors

        public Formula()
        {
        }

        #endregion

        #region Getters & Setters

        public void SetInput(int inputNumber, double input)
        {
            switch (inputNumber)
            {
                case 1:
                    Input1Number = input;
                    Input1Formula = null;
                    break;
                case 2:
                    Input2Number = input;
                    Input2Formula = null;
                    break;
                default:
                    return;
            }
        }

        public void SetInput(int inputNumber, Formula input)
        {
            switch (inputNumber)
            {
                case 1:
                    Input1Formula = input;
                    Input1Number = null;
                    break;
                case 2:
                    Input2Formula = input;
                    Input2Number = null;
                    break;
                default:
                    return;
            }
        }

        public dynamic GetRawInput(int inputNumber)
        {
            switch (inputNumber)
            {
                case 1:
                    if (Input1Number != null)
                    {
                        return Input1Number;
                    }
                    else if(Input1Formula != null)
                    {
                        return Input1Formula;
                    }
                    else
                    {
                        return null;
                    }
                case 2:
                    if (Input2Number != null)
                    {
                        return Input2Number;
                    }
                    else if(Input2Formula != null)
                    {
                        return Input2Formula;
                    }
                    else
                    {
                        return null;
                    }
                default:
                    return null;
            }
        }

        public string GetInput(int inputNumber)
        {
            switch (inputNumber)
            {
                case 1:
                    if (Input1Number != null)
                    {
                        return Input1Number.ToString();
                    }
                    else if (Input1Formula != null)
                    {
                        return "( " + Input1Formula.ToString() + " )";
                    }
                    else
                    {
                        return String.Empty;
                    }
                case 2:
                    if (Input2Number != null)
                    {
                        return Input2Number.ToString();
                    }
                    else if (Input2Formula != null)
                    {
                        return "( " + Input2Formula.ToString() + " )";
                    }
                    else
                    {
                        return String.Empty;
                    }
                default:
                    return String.Empty;
            }
        }
        #endregion

        #region Methods

        public double Calculate(int? roundDecimals)
        {
            double Input1;
            double Input2;
            if (GetInput(1) == String.Empty)
            {
                return 0;
            }
            Input1 = (Input1Number == null ? Input1Formula.Calculate(null) : (Double)Input1Number);

            if (GetInput(2) == String.Empty)
            {
                Answer = Input1;
            }
            else
            {
                Input2 = (Input2Number == null ? Input2Formula.Calculate(null) : (Double)Input2Number);
                switch (Operator)
                {
                    case Operator.Addition:
                        Answer = Input1 + Input2;
                        break;
                    case Operator.Subtraction:
                        Answer = Input1 - Input2;
                        break;
                    case Operator.Multiplication:
                        Answer = Input1 * Input2;
                        break;
                    case Operator.Division:
                        Answer = Input1 / Input2;
                        break;
                    case Operator.Involution:
                        Answer = Math.Pow(Input1, Input2);
                        break;
                    default:
                        Answer = Input1;
                        break;
                }
            }

            if (Answer == null)
            {
                return 0;
            }
            else
            {
                if (roundDecimals != null)
                {
                    Answer = (Double)Math.Round((Double)Answer, (int)roundDecimals);
                }
                return (Double)Answer;
            }
        }

        public override string ToString()
        {
            return ToString(false);
        }

        public string ToString(bool showAllValues)
        {
            if (GetInput(1) == String.Empty)
            {
                return "";
            }
            String returnString = this.GetInput(1);
            if (showAllValues)
            {
                returnString += " " + (char)Operator + " " + GetInput(2);
            }
            else
            {
                if (Operator != 0 && GetInput(2) != String.Empty)
                {
                    returnString += " " + (char)Operator + " " + GetInput(2);
                }
                if (Answer != null)
                {
                    returnString += " = " + Answer.ToString();
                }
            }
            return returnString;
        }

        #endregion

    }
}
