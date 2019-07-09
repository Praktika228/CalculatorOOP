using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ITwoArgumentsCalculator
    {
        double Calculate(double firstOperand, double secondOperand);
    }
}
