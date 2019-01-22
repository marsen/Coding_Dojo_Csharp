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
            ResultShouldBe(3, "Fizz");
        }

        private void ResultShouldBe(int param, string expected)
        {
            var result = fizzBuzz.GetResult(param);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void five_is_buzz()
        {
            var result = fizzBuzz.GetResult(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void nothing_is_value()
        {
            var result = fizzBuzz.GetResult(4);
            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void v195_is_fizzbuzz()
        {
            var result = fizzBuzz.GetResult(195);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}