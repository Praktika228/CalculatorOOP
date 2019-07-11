using System;

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
