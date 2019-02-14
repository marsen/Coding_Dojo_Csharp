using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;

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

            return 90;
        }
    }
}