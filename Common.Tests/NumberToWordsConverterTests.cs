using NUnit.Framework;

namespace Common.Tests
{
	[TestFixture]
	public class NumberToWordsConverterTests
	{
		[TestCase(0.0, "ZERO")]
		[TestCase(1.0, "ONE")]
		[TestCase(2.0, "TWO")]
		[TestCase(3.0, "THREE")]
		[TestCase(4.0, "FOUR")]
		[TestCase(5.0, "FIVE")]
		[TestCase(6.0, "SIX")]
		[TestCase(7.0, "SEVEN")]
		[TestCase(8.0, "EIGHT")]
		[TestCase(9.0, "NINE")]
		public void Add_SingleNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(10.0, "TEN")]
		[TestCase(11.0, "ELEVEN")]
		[TestCase(12.0, "TWELVE")]
		[TestCase(13.0, "THIRTEEN")]
		[TestCase(14.0, "FOURTEEN")]
		[TestCase(15.0, "FIFTEEN")]
		[TestCase(16.0, "SIXTEEN")]
		[TestCase(17.0, "SEVENTEEN")]
		[TestCase(18.0, "EIGHTEEN")]
		[TestCase(19.0, "NINETEEN")]
		public void Add_TeenNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(20.0, "TWENTY")]
		[TestCase(30.0, "THIRTY")]
		[TestCase(40.0, "FORTY")]
		[TestCase(50.0, "FIFTY")]
		[TestCase(60.0, "SIXTY")]
		[TestCase(70.0, "SEVENTY")]
		[TestCase(80.0, "EIGHTY")]
		[TestCase(90.0, "NINETY")]
		[TestCase(23.0, "TWENTY-THREE")]
		[TestCase(77.0, "SEVENTY-SEVEN")]
		[TestCase(98.0, "NINETY-EIGHT")]
		public void Add_TensNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(100.0, "ONE HUNDRED")]
		[TestCase(200.0, "TWO HUNDRED")]
		[TestCase(300.0, "THREE HUNDRED")]
		[TestCase(400.0, "FOUR HUNDRED")]
		[TestCase(500.0, "FIVE HUNDRED")]
		[TestCase(600.0, "SIX HUNDRED")]
		[TestCase(700.0, "SEVEN HUNDRED")]
		[TestCase(800.0, "EIGHT HUNDRED")]
		[TestCase(900.0, "NINE HUNDRED")]
		[TestCase(144.0, "ONE HUNDRED AND FORTY-FOUR")]
		[TestCase(250.0, "TWO HUNDRED AND FIFTY")]
		[TestCase(416.0, "FOUR HUNDRED AND SIXTEEN")]
		public void Add_HundredsNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(1000.0, "ONE THOUSAND")]
		[TestCase(2000.0, "TWO THOUSAND")]
		[TestCase(3000.0, "THREE THOUSAND")]
		[TestCase(4000.0, "FOUR THOUSAND")]
		[TestCase(5000.0, "FIVE THOUSAND")]
		[TestCase(6000.0, "SIX THOUSAND")]
		[TestCase(7000.0, "SEVEN THOUSAND")]
		[TestCase(8000.0, "EIGHT THOUSAND")]
		[TestCase(9000.0, "NINE THOUSAND")]
		[TestCase(1200.0, "ONE THOUSAND TWO HUNDRED")]
		[TestCase(3560.0, "THREE THOUSAND FIVE HUNDRED AND SIXTY")]
		[TestCase(6194.0, "SIX THOUSAND ONE HUNDRED AND NINETY-FOUR")]
		[TestCase(11000.0, "ELEVEN THOUSAND")]
		[TestCase(20000.0, "TWENTY THOUSAND")]
		[TestCase(54800.0, "FIFTY-FOUR THOUSAND EIGHT HUNDRED")]
		[TestCase(85294.0, "EIGHTY-FIVE THOUSAND TWO HUNDRED AND NINETY-FOUR")]
		public void Add_ThousandsNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(1000000.0, "ONE MILLION")]
		[TestCase(10000000.0, "TEN MILLION")]
		[TestCase(16000000.0, "SIXTEEN MILLION")]
		[TestCase(50000000.0, "FIFTY MILLION")]
		[TestCase(6700000.0, "SIX MILLION SEVEN HUNDRED THOUSAND")]
		[TestCase(4820000.0, "FOUR MILLION EIGHT HUNDRED AND TWENTY THOUSAND")]
		[TestCase(52943000.0, "FIFTY-TWO MILLION NINE HUNDRED AND FORTY-THREE THOUSAND")]
		[TestCase(234894200.0, "TWO HUNDRED AND THIRTY-FOUR MILLION EIGHT HUNDRED AND NINETY-FOUR THOUSAND TWO HUNDRED")]
		[TestCase(789452768.0, "SEVEN HUNDRED AND EIGHTY-NINE MILLION FOUR HUNDRED AND FIFTY-TWO THOUSAND SEVEN HUNDRED AND SIXTY-EIGHT")]
		public void Add_MillionssNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(1000000000.0, "ONE BILLION")]
		[TestCase(22000000000.0, "TWENTY-TWO BILLION")]
		[TestCase(456000000000.0, "FOUR HUNDRED AND FIFTY-SIX BILLION")]
		public void Add_BillionssNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(5000000000000.0, "FIVE TRILLION")]
		[TestCase(60000000000000.0, "SIXTY TRILLION")]
		[TestCase(476000000000000.0, "FOUR HUNDRED AND SEVENTY-SIX TRILLION")]
		public void Add_TrillionssNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(4476000000000000.0, "FOUR QUADRILLION FOUR HUNDRED AND SEVENTY-SIX TRILLION")]
		[TestCase(64476000000000000.0, "SIXTY-FOUR QUADRILLION FOUR HUNDRED AND SEVENTY-SIX TRILLION")]
		[TestCase(964476000000000000.0, "NINE HUNDRED AND SIXTY-FOUR QUADRILLION FOUR HUNDRED AND SEVENTY-SIX TRILLION")]
		public void Add_QuadrillionssNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(1.1, "ONE POINT ONE")]
		[TestCase(4.8, "FOUR POINT EIGHT")]
		[TestCase(12.5, "TWELVE POINT FIVE")]
		public void Add_OneDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(6.92, "SIX POINT NINETY-TWO")]
		[TestCase(4.80, "FOUR POINT EIGHT")]
		[TestCase(5.57, "FIVE POINT FIFTY-SEVEN")]
		public void Add_TwoDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.932, "TWO POINT NINE HUNDRED AND THIRTY-TWO")]
		public void Add_ThreeDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.9326, "TWO POINT NINE THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_FourDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.19326, "TWO POINT NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_FiveDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.319326, "TWO POINT THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_SixDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.4319326, "TWO POINT FOUR MILLION THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_SevenDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.54319326, "TWO POINT FIFTY-FOUR MILLION THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_EightDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.654319326, "TWO POINT SIX HUNDRED AND FIFTY-FOUR MILLION THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_NineDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.7654319326, "TWO POINT SEVEN BILLION SIX HUNDRED AND FIFTY-FOUR MILLION THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_TenDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.87654319326, "TWO POINT EIGHTY-SEVEN BILLION SIX HUNDRED AND FIFTY-FOUR MILLION THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_ElevenDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.487654319326, "TWO POINT FOUR HUNDRED AND EIGHTY-SEVEN BILLION SIX HUNDRED AND FIFTY-FOUR MILLION THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_TwelveDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(2.4487654319326, "TWO POINT FOUR TRILLION FOUR HUNDRED AND EIGHTY-SEVEN BILLION SIX HUNDRED AND FIFTY-FOUR MILLION THREE HUNDRED AND NINETEEN THOUSAND THREE HUNDRED AND TWENTY-SIX")]
		public void Add_ThirteenDecimalNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(-3.0, "MINUS THREE")]
		[TestCase(-15.0, "MINUS FIFTEEN")]
		[TestCase(-70.0, "MINUS SEVENTY")]
		[TestCase(-144.0, "MINUS ONE HUNDRED AND FORTY-FOUR")]
		[TestCase(-85294.0, "MINUS EIGHTY-FIVE THOUSAND TWO HUNDRED AND NINETY-FOUR")]
		public void Add_NegativeNumber_ReturnString(decimal number, string expected)
		{
			string result = NumberToWordsConverter.Convert(number);

			Assert.AreEqual(expected, result);
		}
	}
}
