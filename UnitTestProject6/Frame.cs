using System.Collections.Generic;

namespace UnitTestProject6
{
    public class Frame
    {
        public int FirstScore { get; set; }
        public int SecondScore { get; set; }
        public int ThirdScore { get; set; }

        public bool IsSpare { get; set; }

        public bool IsStrike { get; set; }

        public Frame(string input)
        {
            FirstScore = ScoreMap[input.Substring(0, 1)];
            IsStrike = FirstScore == 10;
            var secondBall = input.Substring(1, 1);
            if (secondBall == "/")
            {
                IsSpare = true;
                SecondScore = 10 - FirstScore;
            }
            else
            {
                SecondScore = ScoreMap[secondBall];
            }

            if (input.Length == 3)
            {
                ThirdScore = ScoreMap[input.Substring(2, 1)];
            }
        }

        public static readonly Dictionary<string, int> ScoreMap = new Dictionary<string, int>()
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
        };
    }
}