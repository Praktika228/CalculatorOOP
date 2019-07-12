using System;
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class OneDivOperandCalculatorTests
    {
        [TestCase(2, 0.5)]
        [TestCase(1, 1)]
        [TestCase(3, 0.33)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new OneDivOperandCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
        [Test]
        public void CalculationError()
        {
            var calculator = new LnCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
