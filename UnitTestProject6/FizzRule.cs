namespace UnitTestProject6
{
    public class FizzRule : IRule
    {
        public string Apply( string input, int number)
        {
            return number % 3 == 0 ? input += "Fizz" : input;
        }
    }
}