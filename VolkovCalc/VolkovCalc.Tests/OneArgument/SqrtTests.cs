using NUnit.Framework;
using VolkovCalc.OneArgument;

namespace VolkovCalc.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(25, 5)]
        [TestCase(9, 3)]
        [TestCase(4, 2)]
        public void CalculateTest(double firstValue, double expected)
        {
            ISingleCalc calc = new Sqrt();
            double result = calc.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
