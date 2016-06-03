using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{
    [TestFixture]
    public class MinusTests
    {
        [TestCase(5, 5, 0)]
        [TestCase(7, 4, 3)]
        [TestCase(8, 2, 6)]
        public void MinusTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calc = new Minus();
            double result = calc.Calculate(5, 5);
            Assert.AreEqual(0, result);
        }
    }
}
