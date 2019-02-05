namespace UnitTestProject6
{
    public class BuzzRule : IRule
    {
        public string Apply(int number, string input)
        {
            return number % 5 == 0 ? input += "Buzz" : input;
        }
    }
}