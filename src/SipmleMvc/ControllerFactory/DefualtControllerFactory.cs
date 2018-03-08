using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SipmleMvc.Controller;
using SipmleMvc.Routing;
using System.Reflection;

namespace SipmleMvc.ControllerFactory
{
    public class DefualtControllerFactory : IControllerFactory
    {
        public IController CreateController(RouteData routeData, string controllerName)
        {
            if (routeData == null)
            {
                throw new ArgumentNullException("routeData");
            }

            if (string.IsNullOrEmpty(controllerName))
            {
                throw new ArgumentException("controllerName");
            }
            Type ControllerType = GetControllerType(routeData, controllerName);
            return Activator.CreateInstance(ControllerType) as IController;
        }

        public Type GetControllerType(RouteData routeData, string controllerName)
        {
            object routeNamespaces = routeData.RouteValues["namespaces"];
            object routeAssembly = routeData.RouteValues["assembly"];
            var type = Assembly.Load(routeAssembly.ToString()).GetType(routeNamespaces.ToString() + "." + controllerName + "Controller", false, true);
            return type;
        }

    }
}
