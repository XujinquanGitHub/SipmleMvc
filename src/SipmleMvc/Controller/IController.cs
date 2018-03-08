using System.Web;
using SipmleMvc.Routing;
namespace SipmleMvc.Controller
{
    public interface IController
    {
        void Execute(RouteData routeData);
    }
}
