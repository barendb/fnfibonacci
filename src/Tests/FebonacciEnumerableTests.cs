using System;
using System.Linq;
using FuckingFebonacci;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class FebonacciEnumerableTests
	{
		public static readonly long[] ZERO_BASE_FEBONNACI = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
		public static readonly long[] FEBONNACI = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

		[Test]
		public void Skip_Take_Test()
		{
			var febonaci = new Febonacci(new FebonacciGenerator());
			var result = febonaci.Skip(1).Take(10).ToArray();

			var expected = FEBONNACI.Skip(1).Take(10).ToArray();

			Console.Write(result);

			Assert.AreEqual(expected.Count(), result.Count());
			Assert.AreEqual(ZERO_BASE_FEBONNACI.Skip(1).Take(10).ToArray(), result);

		}
	}
}