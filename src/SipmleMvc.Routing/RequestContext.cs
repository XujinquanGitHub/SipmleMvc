using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SipmleMvc.Routing
{
    public class RequestContext
    {
        public virtual HttpContextBase HttpContext { get; set; }

    }
}
