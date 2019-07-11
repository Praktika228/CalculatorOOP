using System;

namespace Calculator.TwoArgumentsCalculator
{
    public class LogXY : ITwoArgumentsCalculator

    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            if (firstOperand <= 0 || firstOperand == 1) throw new Exception("Недопустимое основание");
            if (secondOperand <= 0) throw new Exception("Недопустимое основание");
            return Math.Log(secondOperand, firstOperand);
        }
    }
}
