
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class ECalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 2.71)]
        [TestCase(2, 7.38)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new ECalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
