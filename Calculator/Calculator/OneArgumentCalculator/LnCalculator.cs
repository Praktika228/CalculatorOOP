using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for ln function
    /// </summary>
    public class LnCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// ln calculation
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// result of ln
        /// </returns>
        public double Calculate(double operand)
        {
            if(operand <= 0) throw new Exception("Логарифм числа меньше 0");
            return Math.Log(operand);
        }
    }
}
