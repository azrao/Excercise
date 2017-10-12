using System;
using System.Globalization;

namespace Common
{
	public static class DecimalValidator
	{
		public static decimal? Validate(string input)
		{
			// trim any whitespace from the number
			input = input.Replace(" ", String.Empty);

			decimal number;

			if (Decimal.TryParse(input,
				NumberStyles.Number,
				CultureInfo.CurrentCulture,
				out number))
			{
				return number;
			}

			return null;
		}
	}
}
