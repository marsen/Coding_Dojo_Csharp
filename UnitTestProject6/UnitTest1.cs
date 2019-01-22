using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBussTest
    {
        [TestMethod]
        public void three_is_fizz()
        {
            FizzBizz fizzBizz = new FizzBizz();
            var result = fizzBizz.GetResult(3);
        }
    }

    internal class FizzBizz
    {
        public FizzBizz()
        {
        }

        public string GetResult(int i)
        {
            throw new NotImplementedException();
        }
    }
}