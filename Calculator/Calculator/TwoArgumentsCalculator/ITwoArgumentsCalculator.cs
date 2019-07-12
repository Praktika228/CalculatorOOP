namespace Calculator.TwoArgumentsCalculator
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// create calculation method with two arguments
        /// </summary>
        /// <param name="firstOperand">
        /// first argument
        /// </param>
        /// <param name="secondOperand">
        /// second argument
        /// </param>
        /// <returns>
        /// result
        /// </returns>
        double Calculate(double firstOperand, double secondOperand);
    }
}
