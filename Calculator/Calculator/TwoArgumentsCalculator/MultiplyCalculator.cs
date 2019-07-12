namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class for multiplication
    /// </summary>
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// multiplication function
        /// </summary>
        /// <param name="firstOperator">
        /// first input operator
        /// </param>
        /// <param name="secondOperator">
        /// second input operator
        /// </param>
        /// <returns>
        /// result of multiplication
        /// </returns>
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator * secondOperator;
        }
    }
}
