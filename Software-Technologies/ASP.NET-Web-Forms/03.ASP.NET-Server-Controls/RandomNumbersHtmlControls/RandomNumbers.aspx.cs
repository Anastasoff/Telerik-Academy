namespace RandomNumbersHtmlControls
{
    using System;
    using System.Web.UI;

    public partial class RandomNumbers : Page
    {
        private Random rnd = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonGenerate_ServerClick(object sender, EventArgs e)
        {
            int from = int.Parse(this.TextBoxFromNumber.Value);
            int to = int.Parse(this.TextBoxToNumber.Value);

            int result = rnd.Next(from, to);

            this.LabelResult.Value = result.ToString();
        }
    }
}