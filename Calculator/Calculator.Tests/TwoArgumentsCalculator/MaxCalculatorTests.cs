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
    class MaxCalculatorTests
    {
        [TestCase(5, 2, 5)]
        [TestCase(6, 2, 6)]
        [TestCase(11, 3, 11)]
        public void CalculationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MaxCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
