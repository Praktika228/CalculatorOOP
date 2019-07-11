using System;
using Calculator.OneArgumentCalculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculator
{
    [TestFixture]
    class OneArgumentFactoryTests
    {
        [TestCase("sqrt", typeof(SqrtCalculator))]
        [TestCase("sin", typeof(SinCalculator))]
        [TestCase("cos", typeof(CosCalculator))]
        [TestCase("e", typeof(ECalculator))]
        [TestCase("ln", typeof(LnCalculator))]
        [TestCase("minusx", typeof(NegativeCalculator))]
        [TestCase("divx", typeof(OneDivOperandCalculator))]
        [TestCase("abs", typeof(AbsoluteCalculator))]
        [TestCase("tan", typeof(TanCalculator))]
        [TestCase("arcsin", typeof(ArcsinCalculator))]
        [TestCase("arccos", typeof(ArccosCalculator))]
        [TestCase("arctan", typeof(ArctanCalculator))]
        [TestCase("ctan", typeof(CtanCalculator))]
        [TestCase("twopow", typeof(TwopowCalculator))]
        [TestCase("tenpow", typeof(TenpowCalculator))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
