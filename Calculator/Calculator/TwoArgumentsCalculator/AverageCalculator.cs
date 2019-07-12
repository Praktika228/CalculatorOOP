namespace Calculator.TwoArgumentsCalculator
{/// <summary>
/// class for finding average of two numbers
/// </summary>
    public class AverageCalculator : ITwoArgumentsCalculator
    {/// <summary>
     ///     function finding average of two operands
     /// </summary>
     /// <param name="firstOperand">
     ///first operand
     /// </param>
     /// <param name="secondOperand">
     ///second operand
     /// </param>
     /// <returns>
     ///result of function
     /// </returns>
        public double Calculate(double firstOperand, double secondOperand)
        {
            return (firstOperand + secondOperand) / 2;
        }
    }
}
