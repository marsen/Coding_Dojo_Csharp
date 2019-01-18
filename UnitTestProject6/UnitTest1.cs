using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void three_is_fizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void five_is_buzzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(5);
            Assert.AreEqual("Buzz", result);
        }
    }
}