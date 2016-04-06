using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Twitch_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional }
            );


            /*This mapRoute could be used for each individual streamer, assigning each one an id, and their display name when parsed, then holding them in a sql database.
            This could be handy in the sense that when you select a user and want to view their stream, perhaps you could take them to their actual stream,
            or view an embedded stream from them on a seperte page created...
            */    
        }
    }
}
