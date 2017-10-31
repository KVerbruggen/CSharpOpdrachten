using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    public static class Calculator
    {
        public static double LastResult { get; private set; }
        
        static Calculator()
        {
            LastResult = 0;
        }

        public static double Calculate(String formula)
        {
            char[] operators = {'+', '-', '×', '÷'};
            // TO-DO
            int operatorIndex = formula.IndexOfAny(operators);
            if (operatorIndex)
            {

            }
            double result = 0;
            LastResult = result;
            return result;
        }
    }
}
