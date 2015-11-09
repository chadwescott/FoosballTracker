using System.Net.Http.Headers;
using System.Web.Http;

namespace Foosball.Web
{
    public class WebApiConfig
    {
        /// <summary>
        /// The Web API URL prefix
        /// </summary>
        public const string UrlPrefix = "api";
        /// <summary>
        /// The relative Web API URL prefix
        /// </summary>
        public const string UrlPrefixRelative = "~/" + UrlPrefix;

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi", string.Concat(UrlPrefix, "/{controller}/{id}"), new { id = RouteParameter.Optional });
        }
    }
}