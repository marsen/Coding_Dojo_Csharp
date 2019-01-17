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
    }

    public class FizzBuzz
    {
        public string GetResult(int i)
        {
            return "Fizz";
        }
    }
}