namespace UnitTestProject6
{
    public class FizzRule : IRule
    {
        public string Word => "Fizz";

        public bool Check(int number)
        {
            return number % 3 == 0;
        }

        public string Apply(string input)
        {
            return input += this.Word;
        }
    }
}