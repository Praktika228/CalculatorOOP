using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// calculator class for e in degree function
    /// </summary>
    public class ECalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// e in degree function
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// result of operation
        /// </returns>
        public double Calculate(double operand)
        {
            return Math.Exp(operand);
        }
    }
}
