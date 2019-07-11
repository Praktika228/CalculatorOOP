using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalculator
{
    public class ECalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Exp(operand);
        }
    }
}
