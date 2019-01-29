using System.Collections.Generic;
using System.Text;

namespace UnitTestProject6
{
    public class FooBarQix
    {
        private Dictionary<int, string> rule = new Dictionary<int, string>()
        {
            {3, "Foo"},
            {5, "Bar"},
            {7, "Qix"},
        };

        public string What(int number)
        {
            string numberString = number.ToString();
            string result = string.Empty;
            foreach (var item in rule.Keys)
            {
                if (number % item == 0)
                {
                    result = rule[item];
                }

                if (number.ToString().Contains(item.ToString()))
                {
                    result += rule[item];
                }
            }

            return string.IsNullOrEmpty(result) ? numberString : result;
        }
    }
}