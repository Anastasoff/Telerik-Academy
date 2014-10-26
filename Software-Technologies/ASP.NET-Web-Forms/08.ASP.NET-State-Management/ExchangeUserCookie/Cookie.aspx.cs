namespace ExchangeUserCookie
{
    using System;
    using System.Web;
    using System.Web.UI;

    public partial class Cookie : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string info = this.TextBoxUsername.Text + this.TextBoxPassword.Text;
            HttpCookie cookie = new HttpCookie("UserName", info);
            cookie.Expires = DateTime.Now.AddMinutes(1);

            Response.Cookies.Add(cookie);
            Response.Redirect("~/SecondPage.aspx");
        }
    }
}