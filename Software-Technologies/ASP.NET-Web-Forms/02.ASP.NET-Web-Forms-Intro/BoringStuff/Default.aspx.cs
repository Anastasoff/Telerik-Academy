using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoringStuff
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello, ASP.NET!!!");
        }

        public string AssemblyLocation()
        {
            return Assembly.GetExecutingAssembly().Location;
        }
    }
}