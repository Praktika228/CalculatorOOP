﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class ArcsinCalculatorTests
    {
        [TestCase(0,0)]
        [TestCase(1, 1.57)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new ArcsinCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}