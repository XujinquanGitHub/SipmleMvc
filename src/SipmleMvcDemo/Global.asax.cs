using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using SipmleMvc.Routing;

namespace SipmleMvcDemo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var Default = new Dictionary<string, object>();
            Default.Add("controller", "Home");
            Default.Add("action", "Index");
            Default.Add("namespaces", "SipmleMvcDemo.Controllers");
            Default.Add("assembly", "SipmleMvcDemo");

            RouteTable.Routes.Add("Default", new Route("/{controller}/{action}", Default, new SipmleMvc.MvcRouteHandler()));
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}