using System;

namespace Calculator.TwoArgumentsCalculator
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            return Math.Min(firstOperand, secondOperand);
        }
    }
}
