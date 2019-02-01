using System;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string what(int i)
        {
            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return "Fizz";
        }
    }
}