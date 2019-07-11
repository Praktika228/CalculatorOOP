using System;

namespace Calculator.TwoArgumentsCalculator
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            return Math.Max(firstOperand, secondOperand);
        }
    }
}
