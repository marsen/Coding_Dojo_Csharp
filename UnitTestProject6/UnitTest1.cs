using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzz fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void three_is_Fizz()
        {
            var what = fizzBuzz.What(3);
            Assert.AreEqual("Fizz", what);
        }

        [TestMethod]
        public void five_is_Buzz()
        {
            var what = fizzBuzz.What(5);
            Assert.AreEqual("Buzz", what);
        }
    }
}