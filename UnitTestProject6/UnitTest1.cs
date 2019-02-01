using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void three_is_Fizz()
        {
            var fizzBuzz = new FizzBuzz();
            var what = fizzBuzz.what(3);
            Assert.AreEqual("Fizz", what);
        }
    }
}