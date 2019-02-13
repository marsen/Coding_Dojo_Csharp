using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class BowlingTests
    {
        [TestMethod]
        public void all_strike_is_300()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("X X X X X X X X X XXX");
            Assert.AreEqual(300, score);
        }
    }
}