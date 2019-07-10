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
                case "sin":
                    return new SinCalculator();
                case "cos":
                    return new CosCalculator();
                case "e":
                    return new ECalculator();
                default:
                    return new SquareCalculator();
            }
        }
    }
}
