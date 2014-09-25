namespace Project.WebAPI
{
    using Microsoft.Owin.Security.OAuth;
    using System.Web.Http;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            // TODO: implement custom routes...
            config.Routes.MapHttpRoute(
               name: "GameDetails",
               routeTemplate: "api/games/{id}",
               defaults: new
               {
                   controller = "Games",
                   action = "Details",
                   id = RouteParameter.Optional
               }
           );

            config.Routes.MapHttpRoute(
                name: "Notifications",
                routeTemplate: "api/notifications/{action}",
                defaults: new
                {
                    controlelr = "Notifications"
                }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // TODO: change position above the config.MapHttpAttributeRoutes(); if does not work here
            // var cors = new EnableCorsAttribute("*", "*", "*");
            // config.EnableCors(cors);
        }
    }
}