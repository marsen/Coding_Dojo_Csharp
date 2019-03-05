﻿using System.Collections.Generic;
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

        public int Score(string input)
        {
            var frameScore = new List<int>();
            var frame = input.Split(',').ToList();
            int xCount = 0;
            int xScore = 0;
            int spareCount = 0;
            bool hasBonus = false;
            frame.ForEach(x =>
            {
                var firstBall = x.Substring(0, 1);
                if (hasBonus)
                {
                    frameScore.Add(map[firstBall]);
                    frameScore.Add(map[firstBall]);
                    hasBonus = false;
                }
                else
                {
                    frameScore.Add(map[firstBall]);
                }

                if (x.Length == 2)
                {
                    var secondBall = x.Substring(1, 1);
                    if (secondBall == "/")
                    {
                        hasBonus = true;
                        frameScore.Add(10 - frameScore.Last());
                    }
                    else
                    {
                        frameScore.Add(map[secondBall]);
                    }
                }

                xCount += x.ToCharArray().Count(y => y.Equals('X'));

                if (x.Contains("5/"))
                {
                    spareCount++;
                }
            });


            if (xCount >= 10)
            {
                return 300;
            }

            if (spareCount == 10)
            {
                return 150;
            }

            return frameScore.Sum();
        }
    }
}