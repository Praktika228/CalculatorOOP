using System;

namespace Calculator.OneArgumentCalculator
{
    public class SqrtCalculator: IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Sqrt(operand);
        }
    }
}
