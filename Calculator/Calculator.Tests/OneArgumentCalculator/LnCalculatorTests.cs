

using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class LnCalculatorTests
    {
        [TestCase(2, 0.69)]
        [TestCase(1, 0)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new LnCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
