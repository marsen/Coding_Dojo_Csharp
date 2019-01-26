using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void three_is_Fizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(3);
            Assert.AreEqual("Fizz", result);
        }
    }
}