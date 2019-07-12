using System;

namespace Calculator.OneArgumentCalculator
{/// <summary>
/// class finding arctan of number
/// </summary>
    public class ArctanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// function to find Arctan of number
        /// </summary>
        /// <param name="operand">
        /// number
        /// </param>
        /// <returns>
        /// result of function
        /// </returns>
        public double Calculate(double operand)
        {
            return Math.Atan(operand);
        }
    }
}
