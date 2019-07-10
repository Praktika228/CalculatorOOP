using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgumentsCalculator;

namespace Calculator.OneArgumentCalculator
{
    class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Tan(operand);
        }
    }
}
