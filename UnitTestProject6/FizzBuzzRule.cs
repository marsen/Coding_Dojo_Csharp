namespace UnitTestProject6
{
    public class FizzBuzzRule : IRule
    {
        public bool Check(int number)
        {
            return number % 15 == 0;
        }

        public string Result => "FizzBuzz";
    }
}