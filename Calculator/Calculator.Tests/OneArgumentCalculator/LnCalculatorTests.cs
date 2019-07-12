

using System;
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class LnCalculatorTests
    {
        [TestCase(2, 0.69)]
        [TestCase(1, 0)]
        [TestCase(2, 1.09)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new LnCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }

        [Test]
        public void CalculationError()
        {
            var calculator = new LnCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-3));
        }
    }
}
