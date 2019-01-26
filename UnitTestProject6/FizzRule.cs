namespace UnitTestProject6
{
    public class FizzRule : IRule
    {
        public bool Check(int number)
        {
            return number % 3 == 0;
        }

        public string Result => "Fizz";
    }
}