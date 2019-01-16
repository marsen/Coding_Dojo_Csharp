using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void fizz_test()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Result();
            Assert.AreEqual("Fizz", result);
        }
    }
}