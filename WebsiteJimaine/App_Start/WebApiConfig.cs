using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebsiteJimaine
{
    /// <summary>
    /// MVC Web Api Config
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register Api
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web-API-Konfiguration und -Dienste

            // Web-API-Routen
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
