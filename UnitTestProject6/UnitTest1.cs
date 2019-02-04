using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTests
    {
        readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void one_is_1()
        {
            var result = _fizzBuzz.GetResult(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void two_is_2()
        {
            var result = _fizzBuzz.GetResult(2);
            Assert.AreEqual("2", result);
        }
    }
}