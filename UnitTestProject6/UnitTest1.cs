using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTests
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

        [TestMethod]
        public void nothing_is_value()
        {
            var result = fizzBuzz.GetResult(4);
            Assert.AreEqual("4", result);
        }
    }

    public class FizzBuzz
    {
        public string GetResult(int i)
        {
            if (i % 3 == 0)
                return "Fizz";
            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return i.ToString();
        }
    }
}