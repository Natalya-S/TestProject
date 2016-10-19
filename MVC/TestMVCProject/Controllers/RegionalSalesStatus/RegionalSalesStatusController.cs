using System.Web.Mvc;

namespace TestMVCProject.Controllers
{
    public class RegionalSalesStatusController : Controller
    {
        // GET: RegionalSalesStatus
        public ActionResult Index()
        {
            ViewBag.Message = "Regional Sales Status page.";

            return View();
        }
    }
}