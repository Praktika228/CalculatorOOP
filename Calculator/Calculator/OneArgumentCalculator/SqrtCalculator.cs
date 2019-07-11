using System;

namespace Calculator.OneArgumentCalculator
{
    public class SqrtCalculator: IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            if(operand < 0) throw new Exception("Корень от отриц числа");
            return Math.Sqrt(operand);
        }
    }
}
