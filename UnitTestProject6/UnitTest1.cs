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
            var score = bowling.Score("X ,X ,X ,X ,X ,X ,X ,X ,X ,XXX");
            Assert.AreEqual(300, score);
        }

        [TestMethod]
        public void ten_9miss_is_90()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("9-,9-,9-,9-,9-,9-,9-,9-,9-,9-");
            Assert.AreEqual(90, score);
        }

        [TestMethod]
        public void ten_5spare_5_is_150()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("5/,5/,5/,5/,5/,5/,5/,5/,5/,5/5");
            Assert.AreEqual(150, score);
        }

        //[TestMethod]
        public void ten_strike_is_270()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("X ,X ,X ,X ,X ,X ,X ,X ,X ,X--");
            Assert.AreEqual(270, score);
        }
    }
}