using SipmleMvc.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SipmleMvc.Routing;

namespace SipmleMvc.ControllerFactory
{
    public interface IControllerFactory
    {
        IController CreateController(RouteData routeData,string controllerName);
    }
}
