using System;

namespace Calculator.OneArgumentCalculator
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Cos(operand);
        }
    }
}
