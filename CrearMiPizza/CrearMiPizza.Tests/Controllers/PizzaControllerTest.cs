using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrearMiPizza.Controllers;
using System.Web.Mvc;
using CrearMiPizza.Models;

namespace CrearMiPizza.Tests.Controllers
{
    [TestClass]
    public class PizzaControllerTest
    {
        [TestMethod]
        public void CrearPizza_CorrectoFuncionamiento_Vista()
        {
            // Arrange
            PizzaController controller = new PizzaController();

            // Act
            ViewResult result = controller.CrearPizza() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GenerarInformePedido_ModeloValido_Vista()
        {
            // Arrange
            PizzaController controller = new PizzaController();
            PizzaModel pizza = new PizzaModel();
            pizza.CiudadEntrega = "algo";
            pizza.DireccionEntrega = "algo";
            pizza.Tamanio = 1;
            pizza.TipoMasa = 1;
            pizza.TipoSalsa = 1;
            pizza.NombreDuenioPizza = "nombre";
            pizza.TelefonoEntrega = "algo";
            // Act
            ViewResult result = controller.GenerarInformePedido(pizza) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GenerarInformePedido_ModeloSinValores_Vista()
        {
            // Arrange
            PizzaController controller = new PizzaController();
            PizzaModel pizza = new PizzaModel();
            ViewResult result = controller.GenerarInformePedido(pizza) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
