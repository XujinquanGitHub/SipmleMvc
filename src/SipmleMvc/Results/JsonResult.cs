using System;
using System.Web;
using Newtonsoft.Json;

namespace SipmleMvc
{
    public class JsonResult : ActionResult
    {
        public object Data { get; set; }
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/json";
            if (Data != null)
            {
                response.Write(JsonConvert.SerializeObject(Data));
            }
        }

    }
}