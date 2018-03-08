using System;
using System.Web;
using SipmleMvc.Routing;

namespace SipmleMvc.Controller
{
    public class ControllerBase : IController
    {

        public void Execute(RouteData routeData)
        {
            HttpContext.Current.Response.Write($"Execute : controller:{routeData.RouteValues["controller"]},action:{routeData.RouteValues["action"]}");
            HttpContext.Current.Response.End();
        }

        public ViewResult View()
        {
            throw new NotImplementedException();
        }

        public JsonResult Json(object data)
        {
            throw new NotImplementedException();
        }
    }
}
