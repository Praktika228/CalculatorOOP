using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class OneDivOperandCalculatorTests
    {
        [TestCase(2, 0.5)]
        [TestCase(1, 1)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new OneDivOperandCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
