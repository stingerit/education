﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// Maps the attribute-defined routes for the application.
			routes.MapMvcAttributeRoutes();

			//routes.MapRoute(
			//	name: "MovieByReleaseDate",
			//	url: "Movie/Released/{year}/{month}",
			//	defaults: new
			//	{
			//		controller = "Movie",
			//		action = "ByReleaseDate",
			//		year = UrlParameter.Optional,
			//		month = UrlParameter.Optional
			//	},
			//	constraints: new
			//	{
			//		year = @"\d{4}",
			//		month = "^(0?[1-9]|1[012])$"
			//	}
			//);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
