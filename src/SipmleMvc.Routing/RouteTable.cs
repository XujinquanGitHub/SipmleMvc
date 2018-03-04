using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipmleMvc.Routing
{
    public class RouteTable
    {
        static RouteTable()
        {
            Routes = new RouteDictionary();
        }
        public static RouteDictionary Routes { get; }
    }
}
