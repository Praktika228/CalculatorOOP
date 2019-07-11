using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class ArctanCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.78)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new ArctanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
