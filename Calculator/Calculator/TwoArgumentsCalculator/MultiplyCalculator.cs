namespace Calculator.TwoArgumentsCalculator
{
    class MultiplyCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator * secondOperator;
        }
    }
}
