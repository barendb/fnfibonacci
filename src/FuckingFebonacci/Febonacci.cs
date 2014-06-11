using System.Collections;
using System.Collections.Generic;

namespace FuckingFebonacci
{
	public class Febonacci : IEnumerable<long>
	{
		private readonly IEnumerator<long> _febonacciGenerator;

		public Febonacci(IEnumerator<long> febonacciGenerator)
		{
			_febonacciGenerator = febonacciGenerator;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _febonacciGenerator;
		}

		public IEnumerator<long> GetEnumerator()
		{
			return _febonacciGenerator;
		}
	}
}