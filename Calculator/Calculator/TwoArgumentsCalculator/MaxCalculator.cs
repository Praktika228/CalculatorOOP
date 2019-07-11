using System;

namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class for max function
    /// </summary>
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function finds maximal argument
        /// </summary>
        /// <param name="firstOperand">
        /// first input operand
        /// </param>
        /// <param name="secondOperand">
        /// second input operand
        /// </param>
        /// <returns>
        /// maximal operand
        /// </returns>
        public double Calculate(double firstOperand, double secondOperand)
        {
            return Math.Max(firstOperand, secondOperand);
        }
    }
}
