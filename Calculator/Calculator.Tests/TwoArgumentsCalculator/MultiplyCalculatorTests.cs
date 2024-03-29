﻿using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Calculator.TwoArgumentsCalculator.MultiplyCalculator();
            double action = calculator.Calculate(5, 2);
            Assert.AreEqual(10, action);
        }
    }
}
