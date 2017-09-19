using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SipmleMvc.Routing
{
    public class UrlRoutingModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            HttpContext currentContext = sender as HttpContext;
            if (currentContext != null)
            {
                currentContext.Response.Write("UrlRoutingModule");
                currentContext.Response.End();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
