using NUnit.Framework;
using VolkovCalc.OneArgument;

namespace VolkovCalc.Tests.OneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(90, 1)]
        [TestCase(180, 2)]
        [TestCase(270, 3)]
        public void SinTest(double firstValue, double expected)
        {
            ISingleCalc calc = new Sin();
            double result = calc.Calculate(90);
            Assert.AreEqual(0.894, result, 0.00001);
        }
    }
}
