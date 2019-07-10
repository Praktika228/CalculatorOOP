using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class SubstractionCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Calculator.TwoArgumentsCalculator.SubstractionCalculator();
            double action = calculator.Calculate(5, 2);
            Assert.AreEqual(3, action);
        }
    }
}
