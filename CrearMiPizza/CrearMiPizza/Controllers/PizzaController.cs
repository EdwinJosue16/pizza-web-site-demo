using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrearMiPizza.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult CrearPizza()
        {
            return View();
        }
    }
}