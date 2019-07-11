using System;

namespace Calculator.OneArgumentCalculator
{
    public  class TenpowCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return Math.Pow(10, operand);
        }
    }
}
