using NUnit.Framework;
using VolkovCalc.OneArgument;

namespace VolkovCalc.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTests
    {

        [Test]           

            public void CalculateTest()
            {
            ISingleCalc calc = new Sqrt();
            double result = calc.Calculate(9);
                Assert.AreEqual(3, result);
            }
        }
    }
}