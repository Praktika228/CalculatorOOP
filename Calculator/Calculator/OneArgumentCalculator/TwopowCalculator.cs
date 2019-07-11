using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalculator
{
    public class TwopowCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Pow(2,operand);
        }
    }
}
