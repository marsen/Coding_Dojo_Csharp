namespace UnitTestProject6
{
    public class FizzRule : IRule
    {
        public string Apply(int number, string input)
        {
            return number % 3 == 0 ? input += "Fizz" : input;
        }
    }
}