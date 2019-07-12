using System;

namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class for finding geometric of two numbers
    /// </summary>
    public class GeometricCalculator : ITwoArgumentsCalculator
    {/// <summary>
    /// function finding geometric mean of two numbers
    /// </summary>
    /// <param name="firstOperand">
    /// first number
    /// </param>
    /// <param name="secondOperand">
    ///second number
    /// </param>
    /// <returns>
    ///result of function
    /// </returns>
        public double Calculate(double firstOperand, double secondOperand)
        {
            return Math.Sqrt(firstOperand*secondOperand);
        }
    }
}
