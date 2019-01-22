using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBussTest
    {
        FizzBuzz fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void three_is_fizz()
        {
            var result = fizzBuzz.GetResult(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void five_is_buzz()
        {
            var result = fizzBuzz.GetResult(5);
            Assert.AreEqual("Buzz", result);
        }
    }
}