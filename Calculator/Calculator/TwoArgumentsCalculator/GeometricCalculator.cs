using System;

namespace Calculator.TwoArgumentsCalculator
{
    public class GeometricCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            return Math.Sqrt(firstOperand*secondOperand);
        }
    }
}
