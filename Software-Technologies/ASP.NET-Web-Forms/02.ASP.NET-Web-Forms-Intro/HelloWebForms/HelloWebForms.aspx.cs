namespace HelloWebForms
{
    using System;
    using System.Web.UI;

    public partial class HelloWebForms : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonGreeting_Click(object sender, EventArgs e)
        {
            this.LiteralGreeting.Text = "Hello " + this.Server.HtmlEncode(TextBoxName.Text);
        }
    }
}