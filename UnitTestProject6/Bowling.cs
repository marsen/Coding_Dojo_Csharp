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
            int result = 0;
            Frame preFrame = null;
            frame.ForEach(x =>
            {
                var f = new Frame(x);
                frameScore.Add(f.FirstScore);
                if (preFrame != null && preFrame.IsSpare)
                {
                    frameScore.Add(f.FirstScore + preFrame.SecondScore);
                }

                if (f.IsSpare == false)
                {
                    frameScore.Add(f.SecondScore);
                }

                if (x.Length == 3)
                {
                    frameScore.Add(f.ThirdScore);
                    frameScore.Add(f.ThirdScore);
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