using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for sinus function
    /// </summary>
    public class SinCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate sinus of operand
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// sinus of operand
        /// </returns>
        public double Calculate(double operand)
        {
            return Math.Sin(operand);
        }
    }
}
