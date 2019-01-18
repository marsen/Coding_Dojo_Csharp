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


            if (IsBuzz(i))
            {
                return "Buzz";
            }

            if (IsFizz(i))
            {
                return "Fizz";
            }

            return i.ToString();
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizzBuzz(int i)
        {
            return IsFizz(i) && IsBuzz(i);
        }
    }
}