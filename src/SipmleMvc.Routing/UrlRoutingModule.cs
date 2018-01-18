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
        public HttpContext CurrentHttpContent { get; set; }
        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            if (app != null)
            {
                CurrentHttpContent = app.Context;
                CurrentHttpContent.Response.Write("UrlRoutingModule");
                CurrentHttpContent.Response.End();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
