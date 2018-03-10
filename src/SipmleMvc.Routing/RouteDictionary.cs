using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SipmleMvc.Routing
{
    public class RouteDictionary : Dictionary<string, Route>
    {
        /// <summary>
        /// 对现有文件应用路由
        /// </summary>
        public bool RouteExistingFiles { get; set; }



        public RouteData GetRouteData(HttpContext context)
        {
            //不应该路由时，查看文件是否存在，如果存在返回Null
            if (!RouteExistingFiles)
            {
                var flag = this.IsRouteToExistingFile(context);
                if (flag)
                {
                    return null;
                }
            }

            foreach (var route in this.Values)
            {
                RouteData routeData = route.GetRouteData(context);
                if (routeData != null)
                {
                    return routeData;
                }
            }
            return null;
        }

        /// <summary>
        /// 访问的路径是否存在文件
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        private bool IsRouteToExistingFile(HttpContext httpContext)
        {
            string appRelativeCurrentExecutionFilePath = httpContext.Request.AppRelativeCurrentExecutionFilePath;
            if (appRelativeCurrentExecutionFilePath == "~/" || !File.Exists(httpContext.Server.MapPath(appRelativeCurrentExecutionFilePath)))
            {
                return false;
            }

            return true;
        }


    }
}
