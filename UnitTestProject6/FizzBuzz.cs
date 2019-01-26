namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            IRule fizzBuzzRule = new FizzBuzzRule();
            if (fizzBuzzRule.Check(number))
            {
                return "FizzBuzz";
            }

            IRule buzzRule = new BuzzRule();
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