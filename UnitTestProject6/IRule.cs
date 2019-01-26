namespace UnitTestProject6
{
    public interface IRule
    {
        bool Check(int number);
        string Result { get; }
    }
}