using System;
using System.Collections.Generic;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            string result = string.Empty;
            if (IsDivisibleBy3(number))
            {
                result += "Fizz";
            }

            if (IsDivisibleBy5(number))
            {
                result += "Buzz";
            }

            if (string.IsNullOrEmpty(result))
            {
                return number.ToString();
            }

            return result;
        }

        private bool IsDivisibleBy15(int number)
        {
            return IsDivisibleBy3(number) && IsDivisibleBy5(number);
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