namespace Calculator.OneArgumentCalculator
{
    class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "sqrt":
                    return new SqrtCalculator();
                default:
                    return new SquareCalculator();
            }
        }
    }
}
