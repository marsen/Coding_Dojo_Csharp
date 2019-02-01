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
            int number = 3;
            string expected = "Fizz";
            ResultShouldBe(number, expected);
        }

        private void ResultShouldBe(int number, string expected)
        {
            var what = _fizzBuzz.What(number);
            Assert.AreEqual(expected, what);
        }

        [TestMethod]
        public void five_is_Buzz()
        {
            int number = 5;
            string expected = "Buzz";
            ResultShouldBe(number, expected);
        }

        [TestMethod]
        public void nothing_is_Value()
        {
            int number = 4;
            string expected = "4";
            ResultShouldBe(number, expected);
        }
    }
}