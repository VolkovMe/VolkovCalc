using NUnit.Framework;
using VolkovCalc.OneArgument;

namespace VolkovCalc.Tests.OneArgument
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(1, 0)]
        [TestCase(1, 0)]
        public void LnTest(double firstValue, double expected)
        {
            ISingleCalc calc = new Ln();
            double result = calc.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
