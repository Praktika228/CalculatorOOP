namespace Calculator.TwoArgumentsCalculator
{
    public class ModCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            return firstOperand % secondOperand;
        }
    }
}
