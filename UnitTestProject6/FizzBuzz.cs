using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnitTestProject6
{
    public class FizzBuzz
    {
        public string GetResult(int i)
        {
            var checkList = new List<Func<int, bool>>();
            checkList.Add(IsFizzBuzz);
            checkList.Add(IsBuzz);
            checkList.Add(IsFizz);

            foreach (var func in checkList)
            {
                if (func(i))
                {
                    return func.GetMethodInfo().Name.Remove(0, 2);
                }
            }

            return i.ToString();
        }

        private bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private bool IsFizzBuzz(int i)
        {
            return IsFizz(i) && IsBuzz(i);
        }
    }
}