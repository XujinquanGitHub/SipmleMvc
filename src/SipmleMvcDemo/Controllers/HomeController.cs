using SipmleMvc;
using SipmleMvc.Controller;

namespace SipmleMvcDemo.Controllers
{
    public class HomeController : ControllerBase
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}