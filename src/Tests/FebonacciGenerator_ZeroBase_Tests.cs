using FuckingFebonacci;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class FebonacciGenerator_ZeroBase_Tests
	{
		public static readonly long[] FEBONNACI = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

		private IFebonacciGenerator _febonacciGenerator;

		[SetUp]
		public void SetUp()
		{
			_febonacciGenerator = new FebonacciGenerator();
		}

		[Test]
		public void GenerateFor_should_return_zerobased_array()
		{
			Assert.AreEqual(FEBONNACI, _febonacciGenerator.GenerateFor(FEBONNACI.Length));
		}

		[Test]
		public void GenerateAt_should_calculate_febonacci_at_position()
		{
			const int pos = 3;

			Assert.AreEqual(FEBONNACI[pos], _febonacciGenerator.GenerateAt(pos));
		}
	}
}