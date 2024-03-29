﻿using System;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Calculator.TwoArgumentsCalculator.DivisionCalculator();
            double action = calculator.Calculate(6, 2);
            Assert.AreEqual(3, action);
        }

        [Test]
        public void CalculationError()
        {
            var calculator = new Calculator.TwoArgumentsCalculator.DivisionCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(2, 0));
        }
    }
}
