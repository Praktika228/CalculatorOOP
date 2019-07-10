namespace Calculator.TwoArgumentsCalculator
{
    class DivisionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator / secondOperator;
        }
    }
}
