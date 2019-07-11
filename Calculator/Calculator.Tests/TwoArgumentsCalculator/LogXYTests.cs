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
    class LogXYTests
    {
        [TestCase(2,8,3)]
        [TestCase(3, 9, 2)]
        [TestCase(2, 4, 2)]
        public void CalculationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new LogXY();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
