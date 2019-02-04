using System;
using System.Collections.Generic;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            if (IsDivisibleBy15(number))
            {
                return "FizzBuzz";
            }

            if (IsDivisibleBy5(number))
            {
                return "Buzz";
            }

            if (IsDivisibleBy3(number))
            {
                return "Fizz";
            }

            return number.ToString();
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