namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            var fizzBuzzRule = new FizzBuzzRule();
            if (fizzBuzzRule.Check(number))
            {
                return "FizzBuzz";
            }

            if (IsBuzz(number))
            {
                return "Buzz";
            }

            if (IsFizz(number))
            {
                return "Fizz";
            }

            return number.ToString();
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}