using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BirthDayApp_webApiOrnegi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}", // birden fazla get veya post olursa bu durumda {action} ekleyip action name de verrerek kontrol sağlayacağız
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter); // bu kod eklendiğinde bir json cıktısı verir yoksa XML çıktısı verecektir.

        }
    }
}
