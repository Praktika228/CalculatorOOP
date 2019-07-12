
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class NegativeCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, -1)]
        [TestCase(2, -2)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new NegativeCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
