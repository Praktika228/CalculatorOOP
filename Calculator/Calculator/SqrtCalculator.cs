using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SqrtCalculator: IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Sqrt(operand);
        }
    }
}
