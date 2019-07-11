using System;

namespace Calculator.OneArgumentCalculator
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            if(operand>1 || operand<-1 ) throw  new  Exception("Недопустимое значение");
            return Math.Acos(operand);
        }
    }
}
