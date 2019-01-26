using System.Collections.Generic;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        readonly List<IRule> _ruleList = new List<IRule>
        {
            new FizzBuzzRule(),
            new BuzzRule(),
            new FizzRule()
        };

        public string GetResult(int number)
        {
            foreach (var rule in _ruleList)
            {
                if (rule.Check(number))
                {
                    return rule.Result;
                }
            }

            return number.ToString();
        }
    }
}