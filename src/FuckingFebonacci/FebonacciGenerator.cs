using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FuckingFebonacci
{
	public class FebonacciGenerator : IFebonacciGenerator, IEnumerator<long>
	{
		private readonly bool _zeroBase;
		private int _position = -1;

		public FebonacciGenerator(bool zeroBase = true)
		{
			_zeroBase = zeroBase;
		}

		private static IEnumerable<long> Calculate(bool zeroBase = true)
		{
			long prev = 0, cur = 1;

			if (zeroBase)
				yield return 0;

			yield return 1;

			while (true)
			{
				var tmp = prev + cur;
				prev = cur;
				cur = tmp;
				yield return cur;
			}
		}

		public long GenerateAt(int pos)
		{
			var result = Calculate(_zeroBase).Take(pos + 1);
			return result.Last();
		}

		public long[] GenerateFor(int count)
		{
			return Calculate(_zeroBase).Take(count).ToArray();
		}

		public bool MoveNext()
		{
			_position++;
			return true; // it's infinate
		}

		public void Reset()
		{
			_position = -1;
		}

		public long Current
		{
			get { return GenerateAt(_position); }
		}

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public void Dispose()
		{
		}
	}
}
