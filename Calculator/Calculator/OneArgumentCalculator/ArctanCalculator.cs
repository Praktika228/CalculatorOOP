using System;

namespace Calculator.OneArgumentCalculator
{
    public class ArctanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Atan(operand);
        }
    }
}
