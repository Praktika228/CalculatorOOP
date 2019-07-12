using System;
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class ArcsinCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.57)]
        [TestCase(0.5, 0.52)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new ArcsinCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }

        [Test]
        public void CalculationError()
        {
            var calculator = new ArcsinCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(5));
        }
    }
}
