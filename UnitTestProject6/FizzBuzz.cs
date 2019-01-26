namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            if (IsFizzBuzz(number))
            {
                return "FizzBuzz";
            }

            else if (IsBuzz(number))
            {
                return "Buzz";
            }

            else if (IsFizz(number))
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        private bool IsFizzBuzz(int number)
        {
            return number % 15 == 0;
        }
    }
}