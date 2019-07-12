namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class for addition function
    /// </summary>
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// addition function
        /// </summary>
        /// <param name="firstOperator">
        /// first input operator
        /// </param>
        /// <param name="secondOperator">
        /// second input operator</param>
        /// <returns>
        /// result of addition
        /// </returns>
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator + secondOperator;
        }
    }
}
