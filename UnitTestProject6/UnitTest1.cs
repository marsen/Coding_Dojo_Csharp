using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTest
    {
        readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void three_is_Fizz()
        {
            ResultShouldBe(3, "Fizz");
        }

        private void ResultShouldBe(int number, string expected)
        {
            var what = _fizzBuzz.What(number);
            Assert.AreEqual(expected, what);
        }

        [TestMethod]
        public void five_is_Buzz()
        {
            ResultShouldBe(5, "Buzz");
        }

        [TestMethod]
        public void nothing_is_Value()
        {
            ResultShouldBe(4, "4");
        }

        [TestMethod]
        public void v195_is_FizzBuzz()
        {
            ResultShouldBe(195, "FizzBuzz");
        }
    }
}