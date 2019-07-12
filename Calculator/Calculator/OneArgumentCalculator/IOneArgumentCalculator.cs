namespace Calculator.OneArgumentCalculator
{
    public interface IOneArgumentCalculator
    {
        /// <summary>
        /// create calculation method with one argument
        /// </summary>
        /// <param name="operand">
        /// argument
        /// </param>
        /// <returns>
        /// result
        /// </returns>
        double Calculate(double operand);
    }
}
