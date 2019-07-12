using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class finding ten to a degree of operand
    /// </summary>
    public class TenpowCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// function to find ten to a degree of number
        /// </summary>
        /// <param name="operand">
        /// number
        /// </param>
        /// <returns>
        /// result of function
        /// </returns>
        public double Calculate(double operand)
        {
            return Math.Pow(10, operand);
        }
    }
}
