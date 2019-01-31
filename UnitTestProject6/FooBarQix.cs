using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject6
{
    public class FooBarQix
    {
        private Dictionary<int, Func<string, string>> rule = new Dictionary<int, Func<string, string>>()
        {
            {3, p => p + "Foo"},
            {5, p => p + "Bar"},
            {7, p => p + "Qix"},
        };

        public string What(int number)
        {
            string numberString = number.ToString();
            string result = string.Empty;
            foreach (var item in rule.Keys)
            {
                if (number % item == 0)
                {
                    result = rule[item].Invoke(result);
                }
            }

            foreach (char c in numberString)
            {
                var tempKey = c.ToString();
                if (rule.Keys.Contains(Convert.ToInt32(tempKey)))
                {
                    result = rule[Convert.ToInt32(tempKey)].Invoke(result);
                }
            }

            return string.IsNullOrEmpty(result) ? numberString : result;
        }
    }
}