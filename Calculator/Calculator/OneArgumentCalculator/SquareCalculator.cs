namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for sqr
    /// </summary>
   public class SquareCalculator: IOneArgumentCalculator
    {
        /// <summary>
        /// square function
        /// </summary>
        /// <param name="operand">
        /// input operand
        /// </param>
        /// <returns>
        /// result 
        /// </returns>
        public double Calculate(double operand)
        {
            return operand * operand;
        }
    }
}
