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
            HttpApplication app = (HttpApplication)sender;
            if (app != null)
            {
                HttpContext currentHttpContent = app.Context;
                RouteData routeData = RouteTable.Routes.GetRouteData(currentHttpContent);
                if (routeData == null)
                {
                    return;
                    //throw new HttpException(404, "没有找到匹配的路由规则！");
                }

                IRouteHandler routeHandler = routeData.RouteHandler;
                if (routeHandler == null)
                {
                    return;
                }

                IHttpHandler currentHandler = routeHandler.GetHttpHandler(routeData, currentHttpContent);
                //设置当前处理程序
                currentHttpContent.RemapHandler(currentHandler);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
