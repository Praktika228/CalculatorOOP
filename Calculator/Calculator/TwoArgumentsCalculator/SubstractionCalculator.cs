namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class for substraction function
    /// </summary>
    public class SubstractionCalculator: ITwoArgumentsCalculator
    {
        /// <summary>
        /// substraction function
        /// </summary>
        /// <param name="firstOperator">
        /// first input operator
        /// </param>
        /// <param name="secondOperator">
        /// second input operator
        /// </param>
        /// <returns>
        /// result of substraction
        /// </returns>
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator - secondOperator;
        }
    }
}
