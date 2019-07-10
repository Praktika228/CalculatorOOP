using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Calculator.TwoArgumentsCalculator.MultiplyCalculator();
            double action = calculator.Calculate(5, 2);
            Assert.AreEqual(10, action);
        }
    }
}
