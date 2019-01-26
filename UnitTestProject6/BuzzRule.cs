namespace UnitTestProject6
{
    public class BuzzRule:IRule
    {
        public bool Check(int number)
        {
            return number % 5 == 0;
        }
    }
}