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

        [TestMethod]
        public void three_is_Fizz()
        {
            var result = _fizzBuzz.GetResult(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void four_is_4()
        {
            var result = _fizzBuzz.GetResult(4);
            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void five_is_5()
        {
            var result = _fizzBuzz.GetResult(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void six_is_6()
        {
            var result = _fizzBuzz.GetResult(6);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void fifteen_is_FizzBuzz()
        {
            var result = _fizzBuzz.GetResult(15);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}