using NUnit.Framework;
using PrimeNumbers;

namespace PrimeNumbersTests
{
	public class PrimeNumberCalculatorTests
	{
		private PrimeNumberCalculator _calculator;
		
		[SetUp]
		public void Setup() => _calculator = new PrimeNumberCalculator();

		[TestCase(0, false)]
		[TestCase(1, false)]
		[TestCase(2, true)]
		[TestCase(3, true)]
		[TestCase(4, false)]
		[TestCase(5, true)]
		[TestCase(6, false)]
		[TestCase(7, true)]
		[TestCase(8, false)]
		[TestCase(9, false)]
		[TestCase(10, false)]
		[TestCase(-1, false)]
		[TestCase(-2, true)]
		[TestCase(-3, true)]
		[TestCase(-4, false)]
		[TestCase(-5, true)]
		[TestCase(int.MaxValue - 1, false)]
		[TestCase(int.MaxValue, true)]
		public void Returns_True_If_Prime(int value, bool expectedResult)
		{
			var result = _calculator.IsPrime(value);
			Assert.AreEqual(expectedResult, result);
		}
	}
}