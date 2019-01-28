using System.Text;

namespace UnitTestProject6
{
    public class FooBarQix
    {
        public string What(int number)
        {
            string result = number.ToString();
            if (number % 3 == 0)
            {
                result = "Foo";
            }

            if (number.ToString().Contains(3.ToString()))
            {
                result += "Foo";
            }

            if (number % 5 == 0)
            {
                result = "Bar";
            }

            if (number.ToString().Contains(5.ToString()))
            {
                result += "Bar";
            }

            if (number % 7 == 0 && number.ToString().Contains(7.ToString()))
            {
                return "QixQix";
            }


            return result;
        }
    }
}