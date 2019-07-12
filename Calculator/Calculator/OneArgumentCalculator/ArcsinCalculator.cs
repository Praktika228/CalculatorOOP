using System;

namespace Calculator.OneArgumentCalculator
{/// <summary>
/// class for finding Arcsin of one number 
/// </summary>
    public class ArcsinCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// function to find Arcsin of number
        /// </summary>
        /// <param name="operand">
        /// number
        /// </param>
        /// <returns>
        /// result of function
        /// </returns>
        public double Calculate(double operand)
        {
            if (operand > 1 || operand < -1) throw new Exception("Недопустимое значение");
            return Math.Asin(operand);
        }
    }
}
