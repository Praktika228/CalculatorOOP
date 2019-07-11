using System;

namespace Calculator.OneArgumentCalculator
{
    public class OneDivOperandCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            if(operand == 0) throw new Exception("Деление на 0");
            return 1 / operand;
        }
    }
}
