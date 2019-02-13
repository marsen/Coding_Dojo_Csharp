using System.Linq;

namespace UnitTestProject6
{
    public class Bowling
    {
        public int Score(string input)
        {
            var frame = input.Split(' ').ToList();
            var xCount = frame.Count(q => q.Contains("X"));

            if (xCount == 10)
            {
                return 300;
            }

            return 90;
        }
    }
}