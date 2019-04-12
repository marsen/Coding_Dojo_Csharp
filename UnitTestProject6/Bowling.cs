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
            var frameScore = new List<int>();
            var frame = input.Split(',').ToList();
            int xCount = 0;
            int bonus = 0;
            int result = 0;
            var hasBonus = false;
            var preSecondScore = 0;
            frame.ForEach(x =>
            {
                var f = new Frame(x);
                var firstScore = f.FirstScore;
                var secondScore = f.SecondScore;
                var thirdScore = f.ThirdScore;
                frameScore.Add(firstScore);
                if (hasBonus)
                {
                    bonus = firstScore + preSecondScore;
                    frameScore.Add(bonus);
                    bonus = 0;
                }

                var secondBall = x.Substring(1, 1);
                if (f.IsSpare)
                {
                    preSecondScore = secondScore;
                    hasBonus = true;
                }
                else
                {
                    frameScore.Add(secondScore);
                }

                if (x.Length == 3)
                {
                    frameScore.Add(thirdScore);
                    frameScore.Add(thirdScore);
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