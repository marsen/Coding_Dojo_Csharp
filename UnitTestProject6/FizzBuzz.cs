using System;
using System.Collections.Generic;
using System.Linq;

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
            var myRules = _rules.Where(r => r.Check(number));
            foreach (var rule in myRules)
            {
                result += rule.Word;
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}