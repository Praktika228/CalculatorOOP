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
    class AverageCalculatorTests
    {
        [TestCase(2, 8, 5)]
        [TestCase(3, 9, 6)]
        [TestCase(2, 4, 3)]
        public void CalculationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AverageCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
