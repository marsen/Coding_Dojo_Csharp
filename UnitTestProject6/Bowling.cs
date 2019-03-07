using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    public class Bowling
    {
        //Dictionary<string, int> ScoreMap = new Dictionary<string, int>()
        //{
        //    {"X", 10},
        //    {"9", 9},
        //    {"8", 8},
        //    {"7", 7},
        //    {"6", 6},
        //    {"5", 5},
        //    {"4", 4},
        //    {"3", 3},
        //    {"2", 2},
        //    {"1", 1},
        //    {"-", 0},
        //    {" ", 0},
        //};

        public int Score(string input)
        {
            var frameScoreList = input.Split(',').Select(x => new Frame(x));
            var frameScore = new List<int>();
            var frame = input.Split(',').ToList();
            int xCount = 0;
            int bonus = 0;
            frame.ForEach(x =>
            {
                var firstScore = Frame.ScoreMap[x.Substring(0, 1)];
                frameScore.Add(firstScore);
                if (bonus != 0)
                {
                    bonus += firstScore;
                    frameScore.Add(bonus);
                    bonus = 0;
                }

                var secondBall = x.Substring(1, 1);
                if (secondBall == "/")
                {
                    bonus = 10 - firstScore;
                }
                else
                {
                    frameScore.Add(Frame.ScoreMap[secondBall]);
                }

                if (x.Length == 3)
                {
                    var thirdBall = x.Substring(2, 1);

                    frameScore.Add(Frame.ScoreMap[thirdBall]);
                    frameScore.Add(Frame.ScoreMap[thirdBall]);
                }

                xCount += x.ToCharArray().Count(y => y.Equals('X'));
            });


            if (xCount >= 10)
            {
                return 300;
            }

            return frameScore.Sum();
        }
    }
}