namespace FuckingFebonacci
{
	public interface IFebonacciGenerator
	{
		long GenerateAt(int pos);
		long[] GenerateFor(int count);
	}
}