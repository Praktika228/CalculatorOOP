using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class TenpowCalculatorTests
    {
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        [TestCase(4, 10000)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new TenpowCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
