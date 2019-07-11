using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for cos function
    /// </summary>
    public class CosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate cos of operand
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// cos of operand
        /// </returns>
        public double Calculate(double operand)
        {
            return Math.Cos(operand);
        }
    }
}
