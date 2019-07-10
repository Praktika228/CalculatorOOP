namespace Calculator.OneArgumentCalculator
{
    class SquareCalculator: IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return operand * operand;
        }
    }
}
