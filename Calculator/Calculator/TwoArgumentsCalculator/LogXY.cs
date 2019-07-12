using System;
namespace Calculator.TwoArgumentsCalculator
{/// <summary>
/// class for finding logarithm
/// </summary>
    public class LogXY : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function for finding logarithm base x of y
        /// </summary>b
        /// <param name="firstOperand">
        /// base of logarithm
        /// </param>
        /// <param name="secondOperand">
        /// number
        /// </param>
        /// <returns>
        ///result of operation
        /// </returns>
        public double Calculate(double firstOperand, double secondOperand)
        {
            if (firstOperand <= 0 || firstOperand == 1) throw new Exception("Недопустимое основание");
            if (secondOperand <= 0) throw new Exception("Недопустимое основание");
            return Math.Log(secondOperand, firstOperand);
        }
    }
}
