namespace UnitTestProject6
{
    public class FizzRule : IRule
    {
        private string Word => "Fizz";

        private bool Check(int number)
        {
            return number % 3 == 0;
        }

        public string Apply(int number, string input)
        {
            return Check(number) ? input += this.Word : input;
        }
    }
}