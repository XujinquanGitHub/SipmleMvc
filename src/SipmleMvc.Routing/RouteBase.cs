using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SipmleMvc.Routing
{
    public abstract class RouteBase
    {
        public abstract RouteData GetRouteData(HttpContext context);

    }
}
