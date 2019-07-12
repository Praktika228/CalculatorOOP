
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class AbsoluteCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(-1, 1)]
        [TestCase(-3, 3)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new AbsoluteCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
