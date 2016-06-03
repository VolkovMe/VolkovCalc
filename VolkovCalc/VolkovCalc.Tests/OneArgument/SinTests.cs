using NUnit.Framework;
using VolkovCalc.OneArgument;

namespace VolkovCalc.Tests.OneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(90, 0.894)]
        [TestCase(180, -0.80115263573383044)]
        [TestCase(270, -0.17604594647121141)]
        public void SinTest(double firstValue, double expected)
        {
            ISingleCalc calc = new Sin();
            double result = calc.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
