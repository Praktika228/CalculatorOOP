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
    class CosCalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.54)]
        public void CalculationTest(double firstValue, double expected)
        {
            var calculator = new CosCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
    }
}
