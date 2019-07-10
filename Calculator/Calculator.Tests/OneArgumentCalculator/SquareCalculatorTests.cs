using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class SquareCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Calculator.OneArgumentCalculator.SquareCalculator();
            double action = calculator.Calculate(9);
            Assert.AreEqual(81, action);
        }
    }
}
