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
            _rules
                .Where(r => r.Check(number))
                .ToList()
                .ForEach(n => result = n.Apply(number,result));
            var normalRule = new NormalRule();
            return normalRule.Apply(number, result);
        }
    }
}