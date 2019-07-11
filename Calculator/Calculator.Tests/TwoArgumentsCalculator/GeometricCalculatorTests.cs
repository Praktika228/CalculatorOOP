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
    class GeometricCalculatorTests
    {
        [TestCase(2, 8, 4)]
        [TestCase(3, 9, 5.19)]
        [TestCase(2, 4, 2.82)]
        public void CalculationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new GeometricCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }

    }
}
