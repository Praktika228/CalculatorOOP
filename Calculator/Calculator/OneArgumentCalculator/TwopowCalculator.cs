using System;

namespace Calculator.OneArgumentCalculator
{/// <summary>
/// class finding two to a degree of operand
/// </summary>
    public class TwopowCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// function finding two to a degree of number
        /// </summary>
        /// <param name="operand">
        /// number
        /// </param>
        /// <returns>
        /// result of function
        /// </returns>
        public double Calculate(double operand)
        {
            return Math.Pow(2, operand);
        }
    }
}
