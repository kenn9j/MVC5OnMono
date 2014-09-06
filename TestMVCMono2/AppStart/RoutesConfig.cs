using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestMVCMono2
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			 routes.MapRoute(
			    name: "App",
				url: "app/{action}",
			    defaults: new { controller = "App", action = "Index" }
			);

			routes.MapRoute(
				name: "App1",
				url: "app1/{action}",
				defaults: new { controller = "App", action = "App1" }
			);

			routes.MapRoute(
				name: "App2",
				url: "app2/{action}",
				defaults: new { controller = "App", action = "App2" }
			);


			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index" }
			);

			//To pass-through to plain ole html/js file, do nothing. IIS is mapped to handle *.html via statichandler
		}
	}
}
