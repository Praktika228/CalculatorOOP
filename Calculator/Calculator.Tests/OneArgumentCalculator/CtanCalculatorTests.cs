using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class CtanCalculatorTests
    {
        [TestCase(1, 0.64)]
        [TestCase(30, -0.15)]
        [TestCase(60, 3.12)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new CtanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
