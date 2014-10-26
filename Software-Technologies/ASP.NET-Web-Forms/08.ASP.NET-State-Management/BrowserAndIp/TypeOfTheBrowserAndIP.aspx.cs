namespace BrowserAndIp
{
    using System;
    using System.Web.UI;

    public partial class TypeOfTheBrowserAndIP : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string browser = this.Request.Browser.Browser;
            string ip = this.Request.UserHostAddress;
            this.LiteralBrowserTypeID.Text += "Your browser is " + browser + "<br />";
            this.LiteralBrowserTypeID.Text += "Your IP address is " + ip;
        }
    }
}