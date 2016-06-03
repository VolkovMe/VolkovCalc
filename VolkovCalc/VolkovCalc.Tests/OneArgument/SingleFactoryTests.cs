using System;
using NUnit.Framework;
using VolkovCalc.OneArgument;

namespace VolkovCalc.Tests.OneArgument
{
    public class SingleFactoryTests
    {
        [TestCase(typeof(Sin), "button1")]
        [TestCase(typeof(Ln), "button2")]
        [TestCase(typeof(Sqrt), "button3")]
        [TestCase(typeof(Sqr), "button4")]
       
        public void CalculateTest(Type expectedTypeOfOperation, string nameOfOperation)
        {
            var calculator = SingleFactory.CreateCalculator(nameOfOperation);

            Assert.IsInstanceOf(expectedTypeOfOperation, calculator);
        }

    }
}
    