using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{   
    [TestFixture]
    public class AddTests
    {
            [Test]

            public void CalculateTest()
            {
                ICalculator calc = new Add();
                double result = calc.Calculate(5,5);
                Assert.AreEqual(10, result);
            }
        }
    }
}