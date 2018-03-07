using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SipmleMvc.Routing
{
    public class Route : RouteBase
    {
        public IRouteHandler RouteHandler { get; private set; }
        public Dictionary<string, object> DefaultPath { get; set; }

        public string Url { get; set; }


        public Route()
        {
            DefaultPath = new Dictionary<string, object>();
        }

        public Route(string url, Dictionary<string, object> defaultPath, IRouteHandler routeHandler)
        {
            Url = url;
            DefaultPath = defaultPath;
            RouteHandler = routeHandler;
        }

        public override RouteData GetRouteData(HttpContext context)
        {
            var routeData = new RouteData() { RouteHandler = this.RouteHandler };
            var url = context.Request.Url.AbsolutePath;
            foreach (var item in this.DefaultPath)
            {
                routeData.RouteValues.Add(item.Key, item.Value);
            }
            if (!string.IsNullOrEmpty(url))
            {
                var routeValueData = url.Split('/');
                routeValueData = routeValueData.Skip(1).ToArray();
                var routePath = this.Url.Split("{}/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                for (int index = 0; index < routeValueData.Length; index++)
                {
                    if (!string.IsNullOrEmpty(routeValueData[index]))
                    {
                        routeData.RouteValues[routePath[index]] = routeValueData[index];
                    }
                }
            }
            return routeData;
        }
    }
}
