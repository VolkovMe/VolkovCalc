using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{
    [TestFixture]
    public class MultiplyTests
    {
        [TestCase(5, 5, 25)]
        [TestCase(3, 7, 21)]
        [TestCase(2, 8, 16)]
        public void MultiplyTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calc = new Multiply();
            double result = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
