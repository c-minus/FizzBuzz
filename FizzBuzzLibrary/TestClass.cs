using System.Collections.Generic;
using FizzBuzzLibrary.Library.Implementation;

namespace FizzBuzzLibrary
{
    public class TestClass
    {
        public void SomeRandomFizzBuzzTest(int employesNumberOfYearsInCompany)
        {
            // add different testcases emp <=3 || emp > 3

            var factory = new FizzBuzzFactory();
            var fizzBuzz = factory.Create(employesNumberOfYearsInCompany);

            var expected = new List<string>(); // add input
            var actual = fizzBuzz.Calculate(30);

            //assert expected = actual
        }
    }
}

