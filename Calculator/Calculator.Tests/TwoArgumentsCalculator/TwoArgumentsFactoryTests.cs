using System;
using Calculator.TwoArgumentsCalculator;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    class TwoArgumentsFactoryTests
    {
        [TestCase("plus", typeof(AdditionCalculator))]
        [TestCase("minus", typeof(SubstractionCalculator))]
        [TestCase("division", typeof(DivisionCalculator))]
        [TestCase("mod", typeof(ModCalculator))]
        [TestCase("min", typeof(MinCalculator))]
        [TestCase("max", typeof(MaxCalculator))]
        [TestCase("logx", typeof(LogXY))]
        [TestCase("average", typeof(AverageCalculator))]
        [TestCase("geometric", typeof(GeometricCalculator))]
        [TestCase("multiply", typeof(MultiplyCalculator))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
