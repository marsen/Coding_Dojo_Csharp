namespace UnitTestProject6
{
    public class BuzzRule : IRule
    {
        public string Word => "Buzz";

        public bool Check(int number)
        {
            return number % 5 == 0;
        }
    }
}