using System;

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
