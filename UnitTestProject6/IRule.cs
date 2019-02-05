namespace UnitTestProject6
{
    public interface IRule
    {
        string Word { get; }
        bool Check(int number);
        string Apply(string input);
    }
}