using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.Add(new XmlMediaTypeFormatter());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "PeeGet",
                routeTemplate: "api/{controller}/get/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "PeeDelete",
                routeTemplate: "api/{controller}/delete/{action}/{id}"
            );

            config.Routes.MapHttpRoute(
                name: "PeePatientPut",
                routeTemplate: "api/{controller}/put/patient/{name}/{age}"
            );

            config.Routes.MapHttpRoute(
                name: "PeePatientPost",
                routeTemplate: "api/{controller}/post/patient/{id}/{dId}",
                defaults: new
                {
                    dId = RouteParameter.Optional
                }
            );

            config.Routes.MapHttpRoute(
                name: "PeeMeasurementPut",
                routeTemplate: "api/{controller}/put/measurement/{id}/{values}"
            );
        }
    }
}
