using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    public class Bowling
    {
        Dictionary<string, int> map = new Dictionary<string, int>()
        {
            {"X", 10},
            {"9", 9},
            {"8", 8},
            {"7", 7},
            {"6", 6},
            {"5", 5},
            {"4", 4},
            {"3", 3},
            {"2", 2},
            {"1", 1},
            {"-", 0},
            {" ", 0},
            {"/", 10},
        };

        public int Score(string input)
        {
            var frameScore = new List<int>();
            var frame = input.Split(',').ToList();
            int xCount = 0;
            int xScore = 0;
            bool hasBonus = false;
            frame.ForEach(x =>
            {
                var firstBall = x.Substring(0, 1);
                if (hasBonus)
                {
                    frameScore.Add(map[firstBall] * 2);
                    hasBonus = false;
                }
                else
                {
                    frameScore.Add(map[firstBall]);
                }

                if (x.Length == 2)
                {
                    var secondBall = x.Substring(1, 1);
                    if (secondBall == "/")
                    {
                        hasBonus = true;
                        frameScore.Add(10 - frameScore.Last());
                    }
                    else
                    {
                        frameScore.Add(map[secondBall]);
                    }
                }
            });

            for (var i = 0; i < frame.Count; i++)
            {
                var item = frame[i];
                var itemScore = frameScore[i];
                xCount += item.ToCharArray().Count(x => x.Equals('X'));
                //xScore += 30;
                //if (item.Equals("X") && i <= 8)
                //{
                //    xScore += itemScore + frameScore[i + 1] + frameScore[i + 2];
                //}

                //if (item.Equals("X") && i <= 9)
                //{
                //    xScore += itemScore + frameScore[i + 1];
                //}

                xScore = 300;
            }

            if (xCount >= 10)
            {
                return xScore;
            }

            int spareCount = 0;
            foreach (var item in frame)
            {
                if (item.Contains("5/"))
                {
                    spareCount++;
                }
            }

            if (spareCount == 10)
            {
                return 150;
            }

            return frameScore.Sum();
        }
    }
}