using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;

namespace OtherAPITopicsProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Formatters.Add(config.Formatters.JsonFormatter);
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.Remove(config.Formatters.JsonFormatter);
            //config.Formatters.Add(config.Formatters.XmlFormatter);
            //JsonMediaTypeFormatter jsonMedia = config.Formatters.JsonFormatter;
            //jsonMedia.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //XmlMediaTypeFormatter xmlMedia = config.Formatters.XmlFormatter;
            //xmlMedia.UseXmlSerializer = true;
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
