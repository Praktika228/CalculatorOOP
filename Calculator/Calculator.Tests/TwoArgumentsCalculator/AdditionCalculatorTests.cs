using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Calculator.TwoArgumentsCalculator.AdditionCalculator();
            double action = calculator.Calculate(5, 2);
            Assert.AreEqual(7, action);
        }
    }
}
