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
                default:
                    return new DivisionCalculator();
            }
        }
    }
}
