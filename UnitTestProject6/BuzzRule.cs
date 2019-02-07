namespace UnitTestProject6
{
    public class BuzzRule : IRule
    {
        public string Apply(string input, int number)
        {
            return number % 5 == 0 ? input += "Buzz" : input;
        }
    }
}