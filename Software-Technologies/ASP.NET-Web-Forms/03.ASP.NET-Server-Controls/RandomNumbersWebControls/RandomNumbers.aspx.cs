namespace RandomNumbersWebControls
{
    using System;
    using System.Web.UI;

    public partial class RandomNumbers : Page
    {
        private Random rnd = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonGenerate_Click(object sender, EventArgs e)
        {
            int from = int.Parse(this.TextBoxFromNumber.Text);
            int to = int.Parse(this.TextBoxToNumber.Text);

            int result = rnd.Next(from, to);

            this.TextBoxResult.Text = result.ToString();
        }
    }
}