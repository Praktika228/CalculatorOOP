namespace Calculator.TwoArgumentsCalculator
{
    /// <summary>
    /// class for mod function
    /// </summary>
    public class ModCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// mod function
        /// </summary>
        /// <param name="firstOperand">
        /// first input function
        /// </param>
        /// <param name="secondOperand">
        /// second input operation
        /// </param>
        /// <returns>
        /// result of mod
        /// </returns>
        public double Calculate(double firstOperand, double secondOperand)
        {
            return firstOperand % secondOperand;
        }
    }
}
