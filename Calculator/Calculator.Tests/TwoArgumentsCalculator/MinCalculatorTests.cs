using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgumentsCalculator;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    class MinCalculatorTests
    {
        [TestCase(5, 2, 2)]
        [TestCase(6, 2, 2)]
        [TestCase(11, 3, 3)]
        public void CalculationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
