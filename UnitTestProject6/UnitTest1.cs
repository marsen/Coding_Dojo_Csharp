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
            ResultShouldBe(5, "Buzz");
        }

        [TestMethod]
        public void nothing_is_value()
        {
            ResultShouldBe(4, "4");
        }

        [TestMethod]
        public void v195_is_fizzbuzz()
        {
            var result = fizzBuzz.GetResult(195);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}