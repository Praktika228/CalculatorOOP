﻿using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class TanCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.55)]
        [TestCase(2, -2.18)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new TanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
