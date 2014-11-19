namespace ForumSystem.Web
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Votes",
                url: "Votes/{action}/{id}/{vote}",
                defaults: new { controller = "Votes", id = UrlParameter.Optional, vote = UrlParameter.Optional });

            // TODO: add page 
            routes.MapRoute(
               name: "PageableFeedbackList",
               url: "PageableFeedbackList/{page}",
               defaults: new { controller = "PageableFeedbackList", action = "Display", page = UrlParameter.Optional });

            routes.MapRoute(
                name: "Feedback",
                url: "feedback",
                defaults: new { controller = "Feedback", action = "Index" });

            routes.MapRoute(
                name: "Get questions by tag",
                url: "questions/tagged/{tag}",
                defaults: new { controller = "Questions", action = "GetByTag" });

            routes.MapRoute(
                name: "Display question",
                url: "questions/{id}/{url}",
                defaults: new { controller = "Questions", action = "Display" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}