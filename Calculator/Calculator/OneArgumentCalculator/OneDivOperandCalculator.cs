using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class for one divide operand operation
    /// </summary>
    public class OneDivOperandCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// ode divide operand operation
        /// </summary>
        /// <param name="operand">
        /// input operation
        /// </param>
        /// <returns>
        /// result of operation
        /// </returns>
        public double Calculate(double operand)
        {
            if(operand == 0) throw new Exception("Деление на 0");
            return 1 / operand;
        }
    }
}
