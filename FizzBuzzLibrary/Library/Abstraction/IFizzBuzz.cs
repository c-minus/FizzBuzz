using System.Collections.Generic;

namespace FizzBuzzLibrary.Library.Abstraction
{
    public interface IFizzBuzz
	{
		public IEnumerable<string> Calculate(int n);
	}
}

