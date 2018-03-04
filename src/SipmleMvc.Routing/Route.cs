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
            var url = context.Request.Url.AbsolutePath;
            return new RouteData() { RouteHandler = this.RouteHandler };
        }
    }
}
