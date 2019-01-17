using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void three_is_fizz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void five_is_buzz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(5);
            Assert.AreEqual("Buzz", result);
        }
    }

    public class FizzBuzz
    {
        public string GetResult(int i)
        {
            if (i % 3 == 0)
            {
                return "Fizz";
            }

            return "Buzz";
        }
    }
}