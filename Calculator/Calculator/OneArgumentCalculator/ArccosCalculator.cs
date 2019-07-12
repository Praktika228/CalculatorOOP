using System;

namespace Calculator.OneArgumentCalculator
{
    /// <summary>
    /// class finding Arccos of operand
    /// </summary>
    public class ArccosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// class finding Arccos of number
        /// </summary>
        /// <param name="operand">
        /// number
        /// </param>
        /// <returns>
        ///result of function
        /// </returns>
        public double Calculate(double operand)
        {
            if(operand>1 || operand<-1 ) throw  new  Exception("Недопустимое значение");
            return Math.Acos(operand);
        }
    }
}
