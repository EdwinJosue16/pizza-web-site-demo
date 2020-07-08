using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrearMiPizza.Models;

namespace CrearMiPizza.Controllers
{
    public class PizzaController : Controller
    {
        public ActionResult CrearPizza()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EnviaDatosCreacion(PizzaModel pizza) {
            return View();
        }
    }
}