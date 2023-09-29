using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute Routing
            routes.MapMvcAttributeRoutes();


            //Convention-based Route
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "Movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" }, //anonymous object
            //    new { year = "\\d{4}", month = "\\d{2}" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
