using System;

namespace Calculator.OneArgumentCalculator
{
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Sin(operand);
        }
    }
}
