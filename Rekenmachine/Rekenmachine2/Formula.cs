using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine2
{
    public struct Formula
    {
        public Operator? Operator { get; set; }

        public double? Number1 { get; set; }

        public double? Number2 { get; set; }

        public Formula(Operator? _operator, double? number1, double? number2)
        {
            Operator = _operator;
            Number1 = number1;
            Number2 = number2;
        }
    }
}
