namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return "Fizz";
        }
    }
}