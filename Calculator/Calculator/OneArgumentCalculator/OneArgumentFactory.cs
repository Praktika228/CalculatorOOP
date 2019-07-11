namespace Calculator.OneArgumentCalculator
{
    public class OneArgumentFactory
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
                case "ln":
                    return new LnCalculator();
                case "minusx":
                    return new NegativeCalculator();
                case "divx":
                    return new OneDivOperandCalculator();
                case "abs":
                    return new AbsoluteCalculator();
                case "tan":
                    return new TanCalculator();
                case "arcsin":
                    return new ArcsinCalculator();
                case "arccos":
                    return new ArccosCalculator();
                case "arctan":
                    return new ArctanCalculator();
                case "ctan":
                    return new CtanCalculator();
                case "twopow":
                    return new TwopowCalculator();
                case "tenpow":
                    return new TenpowCalculator();
                default:
                    return new SquareCalculator();
            }
        }
    }
}
