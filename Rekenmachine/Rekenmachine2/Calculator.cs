using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine2
{
    public enum Operator
    {
        Addition = '+',
        Subtraction = '-',
        Multiplication = '×',
        Division = '÷',
        Involution = '^',
        Rooting = '√',
        Factorial = '!'
    };

    public static class Calculator
    {
        private static Operator? currentFormula_Operator;
        private static double? currentFormula_Number1;
        private static double? currentFormula_Number2;

        public static Formula CurrentFormula
        {
            get {
                return new Formula(currentFormula_Operator, currentFormula_Number1, currentFormula_Number2);
            }
            private set {
                currentFormula_Operator = value.Operator;
                currentFormula_Number1 = value.Number1;
                currentFormula_Number2 = value.Number2;
            }
        }

        public static Stack<Formula> History { get; private set; }

        static Calculator()
        {
            History = new Stack<Formula>();
        }

        public static double Calculate()
        {
            return Calculate(CurrentFormula);
        }

        public static double Calculate(Formula Formula)
        {
            try
            {
                if (Formula.Number1 == null)
                {
                    return 0;
                }
                else if (Formula.Operator == null)
                {
                    return (double)Formula.Number1;
                }
                switch (Formula.Operator)
                {
                    case Operator.Addition:
                        return (double)Formula.Number1 + (double)Formula.Number2;
                    case Operator.Subtraction:
                        return (double)Formula.Number1 - (double)Formula.Number2;
                    case Operator.Multiplication:
                        return (double)Formula.Number1 * (double)Formula.Number2;
                    case Operator.Division:
                        return (double)Formula.Number1 / (double)Formula.Number2;
                    case Operator.Involution:
                        return Math.Pow((double)Formula.Number1, (double)Formula.Number2);
                    case Operator.Rooting:
                        return Math.Pow((double)Formula.Number1, 1.0 / (double)Formula.Number2);
                    case Operator.Factorial:
                        if ((Formula.Number1 % 1 == 0) && Formula.Number1 >= Int32.MinValue && Formula.Number1 <= Int32.MaxValue)
                        {
                            return CalculateFactorial((int)Formula.Number1);
                        }
                        else
                        {
                            throw new CalculationException();
                        }
                    default:
                        throw new CalculationException();
                }
            }
            catch (Exception)
            {
                throw new CalculationException();
            }
        }

        private static int CalculateFactorial(int input)
        {
            int output = input;
            while (input >= 1)
            {
                output *= input;
                input--;
            }
            return output;
        }

        public static void InsertNumber(double number, bool isNumber1)
        {
            if (isNumber1)
            {
                currentFormula_Number1 = number;
            }
            else
            {
                currentFormula_Number2 = number;
            }
        }

        public static void InsertOperator(Operator _operator)
        {
            currentFormula_Operator = _operator;
        }

        public static void InsertCombiningOperator(Operator _operator, double combiningNumber, bool inputFirst, double input)
        {
            double input1;
            double input2;
            if (inputFirst)
            {
                input1 = input;
                input2 = combiningNumber;
            }
            else
            {
                input1 = combiningNumber;
                input2 = input;
            }
            if (currentFormula_Operator == null)
            {
                currentFormula_Operator = _operator;
                currentFormula_Number1 = input;
                currentFormula_Number2 = combiningNumber;
            }
            else
            {
                currentFormula_Number2 = Calculate(new Formula(_operator, input1, input2));
            }
            
        }
    }
}
