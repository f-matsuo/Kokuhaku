using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Kokuhaku
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "roguin",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "roguin", action = "syokigamenn", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "kokuhaku", action = "Index" }
            );

            routes.MapRoute(
                name: "mail",
                url: "{controller}/{action}",
                defaults: new { controller = "kokuhaku", action = "mail" }
            );
        }
    }
}
