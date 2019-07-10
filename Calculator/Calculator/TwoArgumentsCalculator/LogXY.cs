﻿using System;

namespace Calculator.TwoArgumentsCalculator
{
    class LogXY : ITwoArgumentsCalculator

    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            return Math.Log(secondOperand, firstOperand);
        }
    }
}