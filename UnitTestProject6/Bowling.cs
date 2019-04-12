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
            Frame preFrame = null;
            frame.ForEach(x =>
            {
                var f = new Frame(x);
                var firstScore = f.FirstScore;
                var secondScore = f.SecondScore;
                var thirdScore = f.ThirdScore;
                frameScore.Add(firstScore);
                if (preFrame != null && preFrame.IsSpare)
                {
                    bonus = firstScore + preFrame.SecondScore;
                    frameScore.Add(firstScore + preFrame.SecondScore);
                    bonus = 0;
                }

                if (f.IsSpare == false)
                {
                    frameScore.Add(secondScore);
                }

                if (x.Length == 3)
                {
                    frameScore.Add(thirdScore);
                    frameScore.Add(thirdScore);
                }

                xCount += x.ToCharArray().Count(y => y.Equals('X'));
                preFrame = f;
            });


            if (xCount >= 10)
            {
                return 300;
            }

            return frameScore.Sum();
        }
    }
}