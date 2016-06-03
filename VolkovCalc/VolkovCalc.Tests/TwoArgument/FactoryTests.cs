using System;
using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{
    public class FactoryTests
    {
        [TestCase(typeof (Add), "plus")]
        [TestCase(typeof(Minus), "minus")]
        [TestCase(typeof(Multiply), "multiply")]
        [TestCase(typeof(Divided), "divided")]
        public void CalculateTest(Type expectedTypeOfOperation, string nameOfOperation)
        {
            var calculator = Factory.CreateCalculator(nameOfOperation);

            Assert.IsInstanceOf(expectedTypeOfOperation, calculator);
        }

    }
}
    