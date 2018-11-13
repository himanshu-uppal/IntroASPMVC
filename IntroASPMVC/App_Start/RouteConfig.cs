using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IntroASPMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // http://localhost/scriptresource.axd/foo
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // http://localhost/Process/
            routes.MapRoute("Process", "Process/{action}/{id}", new { controller = "Process", action = "List", id = "" });

            // http://localhost/
            // http://localhost/Home
            // http://localhost/Home/About/
            // http://localhost/Home/About/1
            // http://localhost/any/any/1
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
