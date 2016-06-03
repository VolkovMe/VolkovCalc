using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(5, 5, 10)]
        [TestCase(3, 7, 10)]
        [TestCase(2, 8, 10)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            ICalculator calc = new Add();
            double result = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
