using System;
using System.Web;

namespace SipmleMvc
{
    public class ControllerBase : IController
    {
        public void Execute(HttpContext context)
        {
            throw new NotImplementedException();
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
