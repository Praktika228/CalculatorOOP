using System;

namespace Calculator.TwoArgumentsCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            if (secondOperator == 0) throw new Exception("Бан по причине деление на 0");
            return firstOperator / secondOperator;
        }
    }
}
