namespace Calculator.TwoArgumentsCalculator
{
    public class AverageCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            return (firstOperand + secondOperand) / 2;
        }
    }
}
