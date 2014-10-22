namespace HtmlEscaping
{
    using System;
    using System.Web.UI;

    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonShowText_Click(object sender, EventArgs e)
        {
            var inputText = this.TextBoxInputText.Text;
            this.LabelTextOutput.Text = Server.HtmlEncode(inputText);
            this.TextBoxTextOutput.Text = inputText;
        }
    }
}