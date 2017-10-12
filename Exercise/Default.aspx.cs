using System;
using Common;
using System.Text.RegularExpressions;

namespace Exercise
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void SubmitDataAction(object sender, EventArgs e)
		{
			string numberAsWords = String.Empty;
			decimal? decimalNumber = DecimalValidator.Validate(NumberTextBox.Text);

            if (NameValidator.NameValidate(NameTextBox.Text))
            {
                try
                {
                    Name.Text = Server.HtmlEncode(NameTextBox.Text);
                }
                catch
                {
                    WordNumberForm.Visible = false;
                    ErrorMessage.Visible = true;
                }
            }
            else
            {
                ValidationErrorName.Visible = true;
                ValidationErrorName.Text = "Please enter a valid Name.";
            }
            if ((decimalNumber != null && decimalNumber < 1000000000000000000m))
			{
				decimal number = (decimal)decimalNumber;

				try
				{
					numberAsWords = NumberToWordsConverter.Convert(number);
					Number.Text = numberAsWords;

					WordNumberForm.Visible = false;
					SuccessMessage.Visible = true;

                    ValidationSuccess.Visible = true;
                    ValidationSuccess.Text = "Number Converted Successfully.";
                }
				catch
				{
					WordNumberForm.Visible = false;
					ErrorMessage.Visible = true;
				}
            }
			else
			{
				ValidationErrorNumber.Visible = true;
				ValidationErrorNumber.Text = "Please enter a valid Number.";
			}
		}
	}
}
