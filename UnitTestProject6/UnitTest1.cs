using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTests
    {
        readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void three_is_Fizz()
        {
            ResultShouldBe(3, "Fizz");
        }

        [TestMethod]
        public void five_is_Buzz()
        {
            ResultShouldBe(5, "Buzz");
        }

        [TestMethod]
        public void four_is_4()
        {
            ResultShouldBe(4, "4");
        }

        private void ResultShouldBe(int number, string expected)
        {
            var result = _fizzBuzz.GetResult(number);
            Assert.AreEqual(expected, result);
        }
    }
}