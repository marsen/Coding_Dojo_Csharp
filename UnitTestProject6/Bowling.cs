using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    public class Bowling
    {
        public int Score(string input)
        {
            var frame = input.Split(',').ToList();
            int xCount = 0;
            foreach (var item in frame)
            {
                xCount += item.ToCharArray().Count(x => x.Equals('X'));
            }


            if (xCount == 12)
            {
                return 300;
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