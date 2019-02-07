namespace UnitTestProject6
{
    public class NormalRule : IRule
    {
        public string Apply(string input, int number)
        {
            return string.IsNullOrEmpty(input) ? number.ToString() : input;
        }
    }
}