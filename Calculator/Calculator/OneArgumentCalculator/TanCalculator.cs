using System;

namespace Calculator.OneArgumentCalculator
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Tan(operand);
        }
    }
}
