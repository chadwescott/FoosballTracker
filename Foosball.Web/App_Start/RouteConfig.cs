﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Foosball.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Player", action = "Standings", id = UrlParameter.Optional }
            );
        }
    }
}
