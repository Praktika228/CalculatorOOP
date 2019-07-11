using System;

namespace Calculator.OneArgumentCalculator
{
    public class LnCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            if(operand <= 0) throw new Exception("Логарифм числа меньше 0");
            return Math.Log(operand);
        }
    }
}
