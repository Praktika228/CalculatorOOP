using System;

namespace Calculator.OneArgumentCalculator
{/// <summary>
/// class for finding Tan of number
/// </summary>
    public class TanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// function for finding Tan of one operand
        /// </summary>
        /// <param name="operand">
        /// number</param>
        /// <returns>
        /// result of function</returns>
        public double Calculate(double operand)
        {
            return Math.Tan(operand);
        }
    }
}
