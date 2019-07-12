using System;
using Calculator.TwoArgumentsCalculator;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    class LogXYTests
    {
        [TestCase(2, 8, 3)]
        [TestCase(3, 9, 2)]
        [TestCase(2, 4, 2)]
        public void CalculationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new LogXY();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void CalculationError()
        {
            var calculator = new LogXY();
            Assert.Throws<Exception>(() => calculator.Calculate(-3, 1));
        }
    }
}
