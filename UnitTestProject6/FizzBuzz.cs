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

            var buzzRule = new BuzzRule();
            if (buzzRule.Check(number))
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
    }
}