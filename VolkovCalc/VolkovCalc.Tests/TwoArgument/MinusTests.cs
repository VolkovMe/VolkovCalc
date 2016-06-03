using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{   
    [TestFixture]
    public class MinusTests
    {

            [Test]

            public void CalculateTest()
            {
                ICalculator calc = new Minus();
                double result = calc.Calculate(10,5);
                Assert.AreEqual(5, result);
            }
        }
    }
}