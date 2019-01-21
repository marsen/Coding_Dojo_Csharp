namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int i)
        {
            if (IsFizzBuzz(i))
            {
                return "FizzBuzz";
            }

            if (IsFizz(i))
            {
                return "Fizz";
            }

            if (IsBuzz(i))
            {
                return "Buzz";
            }

            return i.ToString();
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private static bool IsFizzBuzz(int i)
        {
            return IsFizz(i) && IsBuzz(i);
        }
    }
}