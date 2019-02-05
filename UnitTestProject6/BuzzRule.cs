namespace UnitTestProject6
{
    public class BuzzRule : IRule
    {
        public string Word => "Buzz";

        public bool Check(int number)
        {
            return number % 5 == 0;
        }

        public string Apply(int number, string input)
        {
            return Check(number) ? input += Word : input;
        }
    }
}