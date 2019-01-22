namespace UnitTestProject6
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string GetResult(int i)
        {
            if (i % 5 == 0)
            {
                return "Buzz";
            }

            if (i % 3 == 0)
            {
                return "Fizz";
            }

            return i.ToString();
        }
    }
}