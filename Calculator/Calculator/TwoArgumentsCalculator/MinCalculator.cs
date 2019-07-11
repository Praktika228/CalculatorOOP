using System;

namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class for min function
    /// </summary>
    public class MinCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function finds minimal argument
        /// </summary>
        /// <param name="firstOperand">
        /// first input operand
        /// </param>
        /// <param name="secondOperand">
        /// second input operand
        /// </param>
        /// <returns>
        /// minimal operand
        /// </returns>
        public double Calculate(double firstOperand, double secondOperand)
        {
            return Math.Min(firstOperand, secondOperand);
        }
    }
}
