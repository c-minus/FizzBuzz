using System.Collections.Generic;
using FizzBuzzLibrary.Library.Abstraction;

namespace FizzBuzzLibrary.Library
{
    public class EvenFizzBuzz : IFizzBuzz
    {
        public IEnumerable<string> Calculate(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    yield return i % 2 == 0 ? "EvenFizz" : "Fizz";
                }
                else if (i % 5 == 0)
                {
                    yield return i % 2 == 0 ? "EvenBuzz" : "Buzz";
                }
                else if (i % 15 == 0)
                {
                    yield return i % 2 == 0 ? "EvenFizzBuzz" : "FizzBuzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}

