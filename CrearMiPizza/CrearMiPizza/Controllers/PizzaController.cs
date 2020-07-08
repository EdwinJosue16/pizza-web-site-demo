using System.Web.Mvc;
using CrearMiPizza.Models;

namespace CrearMiPizza.Controllers
{
    public class PizzaController : Controller
    {
        public ActionResult CrearPizza()
        {
            ViewBag.detallesIngredientes = new DetallesIngredientesModel();
            ViewBag.Message = "";
            if (TempData["Message"]!=null) {
                ViewBag.Message = TempData["Message"].ToString();
            }
            return View();
        }
        [HttpPost]
        public ActionResult EnviaDatosCreacion(PizzaModel pizza) {
            if (pizza != null && ModelState.IsValid)
            {
                return View(pizza);
            }
            else {
                @TempData["Message"] = "Algo salió mal vuelva a efectuar su pedido";
                return RedirectToAction("CrearPizza");
            }
            
        }
    }
}