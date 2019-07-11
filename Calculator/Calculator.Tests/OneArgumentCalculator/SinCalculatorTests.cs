using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class SinCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.84)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new SinCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
