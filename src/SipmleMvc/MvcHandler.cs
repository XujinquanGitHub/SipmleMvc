using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SipmleMvc.Controller;
using SipmleMvc.ControllerFactory;
using SipmleMvc.Routing;

namespace SipmleMvc
{
    public class MvcHandler : IHttpHandler
    {
        public RouteData RouteData { get; set; }
        public HttpContext HttpContext { get; set; }

        public MvcHandler(RouteData routeData, HttpContext httpContext)
        {
            this.RouteData = routeData;
            this.HttpContext = httpContext;
        }

        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            IControllerFactory controllerFactory = new DefualtControllerFactory();
            IController controller = controllerFactory.CreateController(this.RouteData, RouteData.RouteValues["controller"].ToString());
            controller.Execute(RouteData);
            
        }
    }
}
