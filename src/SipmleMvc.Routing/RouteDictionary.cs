using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SipmleMvc.Routing
{
    public class RouteDictionary : Dictionary<string, Route>
    {
        public RouteData GetRouteData(HttpContext context)
        {
            foreach (var route in this.Values)
            {
                RouteData routeData = route.GetRouteData(context);
                if (routeData != null)
                {
                    return routeData;
                }
            }
            return null;
        }
    }
}
