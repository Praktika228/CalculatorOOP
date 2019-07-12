using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class CosCalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.54)]
        [TestCase(2, -0.41)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new CosCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
