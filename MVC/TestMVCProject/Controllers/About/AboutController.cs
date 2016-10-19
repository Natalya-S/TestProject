using System.Web.Mvc;

namespace TestMVCProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            ViewBag.Message = "This is 'About page' which is under construction at the moment.";

            return View();
        }
    }
}