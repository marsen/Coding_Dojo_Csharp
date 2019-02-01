using System;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string What(int i)
        {
            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return "Fizz";
        }
    }
}