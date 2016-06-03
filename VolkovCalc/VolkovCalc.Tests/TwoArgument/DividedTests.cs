using System;
using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{
    [TestFixture]
    public class DividedTests
    {
        [TestCase(10, 5, 2)]
        [TestCase(6, 3, 2)]
        [TestCase(8, 2, 4)]
        public void DividedTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calc = new Divided();
            double result = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            ICalculator calc = new Divided();
            Assert.Throws<Exception>(() => calc.Calculate(5, 0));

        }
    }
}
