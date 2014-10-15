using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CvoBooksDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            ((JsonSerializerSettings)config.Formatters.JsonFormatter.SerializerSettings).ContractResolver = new CamelCasePropertyNamesContractResolver();
         
        }
    }
}
