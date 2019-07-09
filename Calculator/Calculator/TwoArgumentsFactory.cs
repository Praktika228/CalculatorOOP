using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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
                default:
                    return new DivisionCalculator();
            }
        }
    }
}
