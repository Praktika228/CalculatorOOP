using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class finding Ctan of operand
    /// </summary>
    public class CtanCalculator : IOneArgumentCalculator
    {/// <summary>
    /// function to find Ctan of number
    /// </summary>
    /// <param name="operand">
    /// number
    /// </param>
    /// <returns>
    /// result of function
    /// </returns>
        public double Calculate(double operand)
        {
            return 1/Math.Tan(operand);
        }
    }
}
