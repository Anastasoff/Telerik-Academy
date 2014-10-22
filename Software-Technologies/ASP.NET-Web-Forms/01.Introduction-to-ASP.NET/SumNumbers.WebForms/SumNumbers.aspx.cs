namespace SumNumbers.WebForms
{
    using System;

    public partial class SumNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.firstNumberError.InnerText = string.Empty;
            this.secondNumberError.InnerText = string.Empty;
        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;

            if (!double.TryParse(this.tbFirstNumber.Text, out firstNumber))
            {
                this.firstNumberError.InnerText = "Invalid input";
                return;
            }

            if (!double.TryParse(this.tbSecondNumber.Text, out secondNumber))
            {
                this.secondNumberError.InnerText = "Invalid input";
            }

            double result = firstNumber + secondNumber;

            this.Result.Text = result.ToString();
        }
    }
}