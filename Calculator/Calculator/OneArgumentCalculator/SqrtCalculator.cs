using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for sqrt
    /// </summary>
    public class SqrtCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// sqrt function
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// result
        /// </returns>
        public double Calculate(double operand)
        {
            if (operand < 0) throw new Exception("Корень от отриц числа");
            return Math.Sqrt(operand);
        }
    }
}
