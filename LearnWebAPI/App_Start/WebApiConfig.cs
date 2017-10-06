﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LearnWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Attribute routing.
            config.MapHttpAttributeRoutes();

            // Convention-based Default routing.
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            // Convention-based Custom routing.
            config.Routes.MapHttpRoute(
                name: "Products",
                routeTemplate: "api/products/{id}",
                defaults: new { controller = "products", id = RouteParameter.Optional }
            );
        }
    }
}
