using SipmleMvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SipmleMvc
{
    public class MvcRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RouteData routeData, HttpContext httpContext)
        {
            return new MvcHandler(routeData, httpContext);
        }
    }
}
