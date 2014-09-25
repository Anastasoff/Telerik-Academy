namespace Project.WebAPI
{
    using Newtonsoft.Json.Converters;
    using System;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new StringEnumConverter());
            //SerializeSettings(GlobalConfiguration.Configuration);
        }

        // TODO: delete it if I had problems with the users
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        //void SerializeSettings(HttpConfiguration config)
        //{
        //    JsonSerializerSettings jsonSetting = new JsonSerializerSettings();
        //    jsonSetting.Converters.Add(new Converters.StringEnumConverter());
        //    config.Formatters.JsonFormatter.SerializerSettings = jsonSetting;
        //}
    }
}