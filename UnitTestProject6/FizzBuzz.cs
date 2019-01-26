using System.Collections.Generic;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            List<IRule> ruleList = new List<IRule>();
            ruleList.Add(new FizzBuzzRule());
            ruleList.Add(new BuzzRule());
            ruleList.Add(new FizzRule());
            foreach (IRule rule in ruleList)
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