namespace UnitTestProject6
{
    public class NormalRule
    {
        public string Apply(int number,string result)
        {
            return  string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}