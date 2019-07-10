namespace Calculator.TwoArgumentsCalculator
{
    public class DivisionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator / secondOperator;
        }
    }
}
