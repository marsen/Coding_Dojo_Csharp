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

        [TestMethod]
        public void v195_is_fizzbuzz()
        {
            var result = fizzBuzz.GetResult(195);
            Assert.AreEqual("FizzBuzz", result);
        }
    }

    public class FizzBuzz
    {
        public string GetResult(int i)
        {
            if (IsFizzBuzz(i))
            {
                return "FizzBuzz";
            }

            if (IsFizz(i))
            {
                return "Fizz";
            }

            if (IsBuzz(i))
            {
                return "Buzz";
            }

            return i.ToString();
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private static bool IsFizzBuzz(int i)
        {
            return IsBuzz(i) && IsFizz(i);
        }
    }
}