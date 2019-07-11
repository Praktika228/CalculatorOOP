using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class ArccosCalculatorTests
    {
        [TestCase(0, 1.57)]
        [TestCase(1, 0)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new ArccosCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
