using System;

namespace Calculator.OneArgumentCalculator
{
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Abs(operand);
        }
    }
}
