namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for operation of negation
    /// </summary>
    public class NegativeCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// negation operation
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// result of negation
        /// </returns>
        public double Calculate(double operand)
        {
            return - operand;
        }
    }
}
