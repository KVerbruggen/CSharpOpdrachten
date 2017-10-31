using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    public static class Calculator
    {
        public static readonly char[] operators = new char[] { '+', '-', '×', '÷' };
        public static double LastResult { get; private set; }
        public static double Number1 { get; set; }
        public static double Number2 { get; set; }
        public static char LastOp { get; set; } = '+';

        static Calculator()
        {
            LastResult = 0;
        }

        public static double Calculate()
        {
            switch (LastOp)
            {
                case '+':
                    LastResult = Number1 + Number2;
                    break;
                case '-':
                    LastResult = Number1 - Number2;
                    break;
                case '×':
                    LastResult = Number1 * Number2;
                    break;
                case '÷':
                    LastResult = Number1 / Number2;
                    break;
                default:
                    break;
            }
            return LastResult;
        }

        public static double Repeat()
        {
            Number1 = LastResult;
            switch (LastOp)
            {
                case '+':
                    LastResult = Number1 + Number2;
                    break;
                case '-':
                    LastResult = Number1 - Number2;
                    break;
                case '×':
                    LastResult = Number1 * Number2;
                    break;
                case '÷':
                    LastResult = Number1 / Number2;
                    break;
                default:
                    break;
            }
            return LastResult;
        }

        public static void Clear()
        {
            LastResult = 0;
            Number1 = 0;
            Number2 = 0;
            LastOp = '+';
        }
    }
}
