namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            IRule fizzBuzzRule = new FizzBuzzRule();
            if (fizzBuzzRule.Check(number))
            {
                return fizzBuzzRule.Result;
            }

            IRule buzzRule = new BuzzRule();
            if (buzzRule.Check(number))
            {
                return "Buzz";
            }

            IRule fizzRule = new FizzRule();
            if (fizzRule.Check(number))
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}