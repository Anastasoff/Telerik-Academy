namespace GraficWebCounterDataBase
{
    using GraficWebCounterDataBase.Models;
    using System;
    using System.Web;

    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var db = new DataContext();
            db.Counter.Add(new UserCount()
            {
                Count = 1
            });

            db.SaveChanges();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}