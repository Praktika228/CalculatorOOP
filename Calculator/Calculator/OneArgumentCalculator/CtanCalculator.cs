using System;

namespace Calculator.OneArgumentCalculator
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return 1/Math.Tan(operand);
        }
    }
}
