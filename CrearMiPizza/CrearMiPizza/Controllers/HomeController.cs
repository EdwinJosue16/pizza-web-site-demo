using System.Web.Mvc;

namespace CrearMiPizza.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}