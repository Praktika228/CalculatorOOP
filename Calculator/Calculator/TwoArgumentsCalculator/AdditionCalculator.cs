namespace Calculator.TwoArgumentsCalculator
{
    class AdditionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            return firstOperator + secondOperator;
        }
    }
}
