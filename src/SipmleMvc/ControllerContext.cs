using SipmleMvc.Routing;
using System.Web;

namespace SipmleMvc
{
    public class ControllerContext
    {
        private HttpContextBase _httpContext;
        private RequestContext _requestContext;

        public virtual HttpContextBase HttpContext
        {
            get
            {
                if (_httpContext == null)
                {
                    _httpContext = (_requestContext != null) ? _requestContext.HttpContext : new EmptyHttpContext();
                }
                return _httpContext;
            }
            set { _httpContext = value; }
        }

        private sealed class EmptyHttpContext : HttpContextBase
        {

        }
    }

}