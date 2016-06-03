using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{  
    [TestFixture]
    public class DividedTests
    {

            [Test]

            public void CalculateTest()
            {
                ICalculator calc = new Divided();
                double result = calc.Calculate(4,2);
                Assert.AreEqual(2, result);
            }
        }
    }
}