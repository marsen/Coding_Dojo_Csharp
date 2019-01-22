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

            return "Fizz";
        }
    }
}