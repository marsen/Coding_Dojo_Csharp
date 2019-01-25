using System.Text;

namespace UnitTestProject6
{
    public class FooBarQix
    {
        public string What(int number)
        {
            if (number % 3 == 0 && number.ToString().Contains(3.ToString()))
            {
                return "FooFoo";
            }

            return number.ToString();
        }
    }
}