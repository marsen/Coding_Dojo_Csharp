using System;
using System.Collections.Generic;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        private readonly List<IRule> _rules = new List<IRule>
        {
            new FizzRule(),
            new BuzzRule(),
        };

        public string GetResult(int number)
        {
            string result = string.Empty;
            var myRules = _rules;
            foreach (var rule in myRules)
            {
                if (rule.Check(number))
                {
                    result += rule.Word;
                }
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}