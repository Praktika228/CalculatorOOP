using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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
