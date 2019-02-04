namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            if (IsDivisibleBy3(number) && IsDivisibleBy5(number))
            {
                return "FizzBuzz";
            }

            if (IsDivisibleBy5(number))
            {
                return "Buzz";
            }

            if (IsDivisibleBy3(number))
            {
                return "Fizz";
            }

            return number.ToString();
        }

        private static bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }
    }
}