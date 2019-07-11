

using Calculator.TwoArgumentsCalculator;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    class ModCalculatorTests
    {
        [TestCase(5,2,1)]
        [TestCase(6, 2, 0)]
        [TestCase(11, 3, 2)]
        public void CalculationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new ModCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
