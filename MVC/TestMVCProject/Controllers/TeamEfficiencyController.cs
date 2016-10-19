using System.Web.Mvc;

namespace TestMVCProject.Controllers
{
    public class TeamEfficiencyController : Controller
    {
        // GET: TeamEfficiency
        public ActionResult Index()
        {
            ViewBag.Message = "Team Efficiency chart.";

            return View();
        }
    }
}