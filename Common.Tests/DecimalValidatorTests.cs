using NUnit.Framework;

namespace Common.Tests
{
	[TestFixture]
	public class DecimalValidatorTests
	{
		[TestCase("9.0", 9.0)]
		[TestCase("34.2", 34.2)]
		[TestCase("554.84285592", 554.84285592)]
		public void Add_DecimalNumber_ReturnDecimal(string number, decimal expected)
		{
			decimal? result = DecimalValidator.Validate(number);

			Assert.IsNotNull(result);
			Assert.AreEqual(expected, (decimal)result);
		}

		[TestCase("4", 4.0)]
		[TestCase("567", 567.0)]
		public void Add_Integer_ReturnDecimal(string number, decimal expected)
		{
			decimal? result = DecimalValidator.Validate(number);

			Assert.IsNotNull(result);
			Assert.AreEqual(expected, (decimal)result);
		}

		[TestCase("8,9.0", 89.0)]
		[TestCase("1,345,978.0", 1345978.0)]
		public void Add_NumberWithThousandSeparators_ReturnDecimal(string number, decimal expected)
		{
			decimal? result = DecimalValidator.Validate(number);

			Assert.IsNotNull(result);
			Assert.AreEqual(expected, (decimal)result);
		}

		[TestCase("8 9.0", 89.0)]
		[TestCase("1 345 978.0", 1345978.0)]
		public void Add_NumberWithSpaces_ReturnDecimal(string number, decimal expected)
		{
			decimal? result = DecimalValidator.Validate(number);

			Assert.IsNotNull(result);
			Assert.AreEqual(expected, (decimal)result);
		}

		[TestCase("-4", -4.0)]
		[TestCase("-34.2", -34.2)]
		[TestCase("-5,978.0", -5978.0)]
		public void Add_NegativeNumber_ReturnDecimal(string number, decimal expected)
		{
			decimal? result = DecimalValidator.Validate(number);

			Assert.IsNotNull(result);
			Assert.AreEqual(expected, (decimal)result);
		}

		[TestCase("xcvxv", null)]
		[TestCase("$23.45", null)]
		public void Add_String_ReturnNull(string number, decimal? expected)
		{
			decimal? result = DecimalValidator.Validate(number);

			Assert.AreEqual(expected, result);
		}
	}
}
