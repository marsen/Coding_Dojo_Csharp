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
            string result = string.Empty;
            _rules
                .ForEach(n => result = n.Apply(number, result));
            return result;
        }
    }
}