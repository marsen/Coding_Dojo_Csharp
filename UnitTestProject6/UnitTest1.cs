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

        [TestMethod]
        public void ten_2_2_is_40()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("22,22,22,22,22,22,22,22,22,22");
            Assert.AreEqual(40, score);
        }

        [TestMethod]
        public void two_1_miss_is_2()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("1-,1-");
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void ten_1_miss_is_10()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("1-,1-,1-,1-,1-,1-,1-,1-,1-,1-");
            Assert.AreEqual(10, score);
        }

        [TestMethod]
        public void ten_miss_miss_is_0()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("--,--,--,--,--,--,--,--,--,--");
            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void two_1_1_is_4()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("11,11");
            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void two_miss_1_is_2()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("-1,-1");
            Assert.AreEqual(2, score);
        }


        [TestMethod]
        public void frames_1_spare_1_1_is_13()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("1/,11");
            Assert.AreEqual(13, score);
        }


        [TestMethod]
        public void frames_1_spare_2_1_is_15()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("1/,21");
            Assert.AreEqual(15, score);
        }

        [TestMethod]
        public void frames_1_spare_1_2_is_14()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("1/,12");
            Assert.AreEqual(14, score);
        }

        [TestMethod]
        public void frames_1spare_2spare_1spare_2spare_11_is_48()
        {
            Bowling bowling = new Bowling();
            var score = bowling.Score("1/,2/,1/,2/,11");
            Assert.AreEqual(48, score);
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