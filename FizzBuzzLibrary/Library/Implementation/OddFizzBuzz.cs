using System.Collections.Generic;
using FizzBuzzLibrary.Library.Abstraction;

namespace FizzBuzzLibrary.Library.Implementation
{
    public class OddFizzBuzz : IFizzBuzz
    {
        public IEnumerable<string> Calculate(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    yield return "Fizz";
                }
                else if (i % 5 == 0)
                {
                    yield return "Buzz";
                }
                else if (i % 15 == 0)
                {
                    yield return "FizzBuzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}

