using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzz fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void three_is_fizz()
        {
            var param = 3;
            var expected = "Fizz";
            var result = fizzBuzz.GetResult(param);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void five_is_buzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(5);
            Assert.AreEqual("Buzz", result);
        }
    }
}