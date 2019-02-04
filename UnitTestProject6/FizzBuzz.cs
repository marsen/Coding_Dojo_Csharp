using System;
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
                result += fizzRule.Word;
            }

            var buzzRule = new BuzzRule();
            if (buzzRule.Check(number))
            {
                result += buzzRule.Word;
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}