using System;

namespace Calculator.OneArgumentCalculator
{
    class SqrtCalculator: IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Sqrt(operand);
        }
    }
}
