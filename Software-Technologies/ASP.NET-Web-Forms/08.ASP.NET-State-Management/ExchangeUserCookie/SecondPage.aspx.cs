namespace ExchangeUserCookie
{
    using System;
    using System.Web;
    using System.Web.UI;

    public partial class SecondPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserName"];

            if (cookie != null)
            {
                this.CoockieInfo.Text = cookie.Value;
            }
            else
            {
                Response.Redirect("~/Cookie.aspx");
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserName"];

            if (cookie != null)
            {
                this.CoockieInfo.Text = cookie.Value;
            }
            else
            {
                Response.Redirect("~Cookie.aspx");
            }
        }
    }
}