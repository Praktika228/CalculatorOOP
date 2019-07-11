using System;
using System.Windows.Forms;

namespace Calculator.TwoArgumentsCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperator, double secondOperator)
        {
            if (secondOperator == 0) throw new Exception("Деление на 0");
            return firstOperator / secondOperator;
        }
    }
}
