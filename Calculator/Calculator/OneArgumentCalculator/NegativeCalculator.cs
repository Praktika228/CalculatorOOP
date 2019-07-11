namespace Calculator.OneArgumentCalculator
{
    public class NegativeCalculator : IOneArgumentCalculator
    {
        public double Calculate(double operand)
        {
            return 0 - operand;
        }
    }
}
