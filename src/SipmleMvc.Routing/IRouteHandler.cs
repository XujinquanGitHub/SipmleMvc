using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SipmleMvc.Routing
{
    public interface IRouteHandler
    {
        IHttpHandler GetHttpHandler(RouteData routeData, HttpContext httpContext);
    }
}