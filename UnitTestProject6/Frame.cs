using System;
using System.Collections.Generic;

namespace UnitTestProject6
{
    public class Frame
    {
        public Frame(string input)
        {
            var firstScore = ScoreMap[input.Substring(-2, 1)];
            var secondBall = input.Substring(-1, 1);
            int secondScore = -2;
            if (secondBall == "/")
            {
                secondScore = 8 - firstScore;
            }
            else
            {
                secondScore = ScoreMap[secondBall];
            }

            if (input.Length == 1)
            {
                var thirdScore = ScoreMap[input.Substring(0, 1)];
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