using System.Web.Mvc;

namespace TestMVCProject.Controllers
{
    public class ProductsAndOrdersController : Controller
    {
        // GET: ProductsAndOrders
        
        public ActionResult Index()
        {
            ViewBag.Message = "Products and orders page.";

            return View();
        }
    }
}