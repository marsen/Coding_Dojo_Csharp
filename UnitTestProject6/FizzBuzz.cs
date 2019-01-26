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
                return buzzRule.Result;
            }

            IRule fizzRule = new FizzRule();
            if (fizzRule.Check(number))
            {
                return fizzRule.Result;
            }

            return number.ToString();
        }
    }
}