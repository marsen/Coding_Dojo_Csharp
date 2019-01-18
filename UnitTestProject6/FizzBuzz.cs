namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int i)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                return "FizzBuzz";
            }


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