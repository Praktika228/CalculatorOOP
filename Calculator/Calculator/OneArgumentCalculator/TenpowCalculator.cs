using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalculator
{
    public  class TenpowCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Pow(10, operand);
        }
    }
}
