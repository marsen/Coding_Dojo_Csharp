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
            new NormalRule()
        };

        public string GetResult(int number)
        {
            return _rules.Aggregate(string.Empty, (input, rule) => rule.Apply(input, number));
        }
    }
}