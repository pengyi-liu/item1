using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace happy_aoligei
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "HomePage",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "DefaultAction",
                url: "{action}",
                defaults: new { controller = "Default", action = "{action}", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "OtherPage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Repair", action = "Apply", id = UrlParameter.Optional }
            );
        }
    }
}
