using NUnit.Framework;
using VolkovCalc.OneArgument;

namespace VolkovCalc.Tests.OneArgument
{
    [TestFixture]
    public class SqrTests
    {
        [TestCase(5, 25)]
        [TestCase(3, 9)]
        [TestCase(2, 4)]
        public void CalculateTest(double firstValue, double expected)
        {
            ISingleCalc calc = new Sqr();
            double result = calc.Calculate(5);
            Assert.AreEqual(25, result);
        }
    }
}
