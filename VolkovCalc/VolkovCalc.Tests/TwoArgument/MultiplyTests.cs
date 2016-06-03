using NUnit.Framework;
using VolkovCalc.TwoArguments;

namespace VolkovCalc.Tests.TwoArgument
{
     [TestFixture]
    public class MultiplyTests
    {
            [Test]

            public void CalculateTest()
            {
                ICalculator calc = new Multiply();
                double result = calc.Calculate(2,2);
                Assert.AreEqual(4, result);
            }
        }
    
}