namespace Calculator.TwoArgumentsCalculator
{
    public class SubstractionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator - secondOperator;
        }
    }
}
