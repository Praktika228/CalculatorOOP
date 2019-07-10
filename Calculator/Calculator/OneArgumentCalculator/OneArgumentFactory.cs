using System.Windows.Forms.VisualStyles;

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
                default:
                    return new SquareCalculator();
            }
        }
    }
}
