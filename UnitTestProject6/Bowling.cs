using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Versioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    public class Bowling
    {
        public int Score(string input)
        {
            var frameScoreList = input.Split(',').Select(x => new Frame(x));
            var frameScore = new List<int>();
            var frame = input.Split(',').ToList();
            int xCount = 0;
            int bonus = 0;
            int result = 0;
            //foreach (var item in frameScoreList)
            //{
            //    result += item.FirstScore;

            //    if (bonus != 0)
            //    {
            //        bonus += item.FirstScore;
            //        result += bonus;
            //        bonus = 0;
            //    }

            //    result += item.SecondScore;
            //}

            var hasBonus = false;
            var preSecondScore = 0;
            frame.ForEach(x =>
            {
                //var firstScore = Frame.ScoreMap[x.Substring(0, 1)];
                var f = new Frame(x);
                var firstScore = f.FirstScore;
                frameScore.Add(firstScore);
                if (hasBonus)
                {
                    bonus = firstScore + preSecondScore;
                    frameScore.Add(bonus);
                    bonus = 0;
                }

                var secondBall = x.Substring(1, 1);
                if (secondBall == "/")
                {
                    preSecondScore = 10 - firstScore;
                    hasBonus = true;
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