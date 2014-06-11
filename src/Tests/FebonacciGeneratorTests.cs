using FuckingFebonacci;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class FebonacciGeneratorTests
	{
		public static readonly long[] FEBONNACI = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

		private IFebonacciGenerator _febonacciGenerator;

		[SetUp]
		public void SetUp()
		{
			_febonacciGenerator = new FebonacciGenerator(false);
		}

		[Test]
		public void GenerateFor_should_return_non_zerobased_array()
		{
			Assert.AreEqual(FEBONNACI, _febonacciGenerator.GenerateFor(FEBONNACI.Length));
		}

		[Test]
		public void GenerateAt_should_calculate_febonacci_at_position()
		{
			const int pos = 5;

			Assert.AreEqual(FEBONNACI[pos], _febonacciGenerator.GenerateAt(pos));
		}
	}
}