namespace Calculator.OneArgumentCalculator
{
   public class SquareCalculator: IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return operand * operand;
        }
    }
}
