using System;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class SqrtCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Calculator.OneArgumentCalculator.SqrtCalculator();
            double actual = calculator.Calculate(81);
            Assert.AreEqual(9,actual);
        }

        [Test]
        public void CalculationError()
        {
            var calculator = new Calculator.OneArgumentCalculator.SqrtCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-3));
        }
    }
}
