using FizzBuzzLibrary.Library.Abstraction;

namespace FizzBuzzLibrary.Library.Implementation
{
    public class FizzBuzzFactory
    {
        public IFizzBuzz Create(int employesNumberOfYearsInCompany)
            => employesNumberOfYearsInCompany <= 3 ?
            new OddFizzBuzz() : new EvenFizzBuzz();
    }
}

