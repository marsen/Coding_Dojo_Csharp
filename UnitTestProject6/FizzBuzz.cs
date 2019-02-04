﻿using System;
using System.Collections.Generic;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            string result = string.Empty;
            var fizzRule = new FizzRule();
            if (fizzRule.Check(number))
            {
                result += "Fizz";
            }

            if (IsDivisibleBy5(number))
            {
                result += "Buzz";
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }


        private bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }

        private bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }
    }
}