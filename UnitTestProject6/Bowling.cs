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
            {"-", 0},
        };

        public int Score(string input)
        {
            var frameScore = new List<int>();
            var frame = input.Split(',').ToList();
            int xCount = 0;
            int result = 0;
            int xScore = 0;

//            frame.ForEach(x => { frameScore.Add(map[x.Substring(0, 1)]); });

            for (var i = 0; i < frame.Count; i++)
            {
                var item = frame[i];
//                var itemScore = frameScore[i];
                xCount += item.ToCharArray().Count(x => x.Equals('X'));
                xScore += 30;
            }

            if (xCount == 12)
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

            return 90;
        }
    }
}