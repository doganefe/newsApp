using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HaberSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("anasayfa", "", new { Controller = "Home", Action = "Index" });
            routes.MapRoute("Home","home",new { Controller="Home",Action="Index"});
            routes.MapRoute("Weather", "weather", new { Controller = "Weather", Action = "HavaDurumu" });
            routes.MapRoute("Contact", "contact", new { Controller = "Contact", Action = "Index" });
        }
    }
}
