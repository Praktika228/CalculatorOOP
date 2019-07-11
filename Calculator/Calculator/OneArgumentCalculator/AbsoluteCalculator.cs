using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for finding absolute value
    /// </summary>
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// absolute operation
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// result of operation
        /// </returns>
        public double Calculate(double operand)
        {
            return Math.Abs(operand);
        }
    }
}
