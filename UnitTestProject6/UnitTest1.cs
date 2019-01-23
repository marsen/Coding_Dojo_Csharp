using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTests
    {
        readonly FizzBuzz _fizzBuzz = new FizzBuzz();


        private void ResultShouldBe(int number, string expected)
        {
            var result = _fizzBuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void three_is_fizz()
        {
            ResultShouldBe(3, "Fizz");
        }

        [TestMethod]
        public void five_is_buzz()
        {
            var result = _fizzBuzz.GetResult(5);
            Assert.AreEqual("Buzz", result);
        }
    }
}