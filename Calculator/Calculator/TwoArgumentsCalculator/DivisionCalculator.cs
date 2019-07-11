using System;
using System.Windows.Forms;

namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class to divide numbers
    /// </summary>
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// division realisation
        /// </summary>
        /// <param name="firstOperator">
        /// first input operator
        /// </param>
        /// <param name="secondOperator">
        /// second input operator
        /// </param>
        /// <returns>
        /// result of division
        /// </returns>
        public double Calculate(double firstOperator, double secondOperator)
        {
            if (secondOperator == 0) throw new Exception("Деление на 0");
            return firstOperator / secondOperator;
        }
    }
}
