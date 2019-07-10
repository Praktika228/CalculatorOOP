namespace Calculator.TwoArgumentsCalculator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "plus":
                    return  new AdditionCalculator();
                case "minus":
                    return  new SubstractionCalculator();
                case "multiply":
                    return  new MultiplyCalculator();
                case "mod":
                    return new ModCalculator();
                case "min":
                    return  new MinCalculator();
                case "max":
                    return new MaxCalculator();
                case "logx":
                    return new LogXY();
                case "average":
                    return new AverageCalculator();
                case "geometric":
                    return new GeometricCalculator();
                default:
                    return new DivisionCalculator();
            }
        }
    }
}
