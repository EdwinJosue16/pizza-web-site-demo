using CrearMiPizza.Models;

namespace CrearMiPizza.Servicios
{
    public class CalculadoraPrecios
    {
        PizzaModel Pizza;
        DetallesIngredientesModel DetallesIngredientes;

        public CalculadoraPrecios() {
            Pizza = new PizzaModel();
            DetallesIngredientes = new DetallesIngredientesModel();
        }

        public CalculadoraPrecios(PizzaModel pizza)
        {
            Pizza = pizza;
            DetallesIngredientes = new DetallesIngredientesModel();
        }

        private double PrecioXIngredientes() {
            double precio = 0.0;
            if (Pizza.IngredientesId!=null) {
                foreach (var identificador in Pizza.IngredientesId) {
                    precio += DetallesIngredientes.PreciosIngredientes[identificador];
                }
            }
            return precio;
        }

        private double PrecioXMasa() {
           return DetallesIngredientes.PrecioMasas[Pizza.TipoMasa];
        }

        private double PrecioXSalsa() {
           return DetallesIngredientes.PrecioMasas[Pizza.TipoSalsa];
        }

        private double PrecioXTamanio(double precioFinal) {
            return precioFinal * DetallesIngredientes.IncrementoPrecioXTamanio[Pizza.Tamanio];
        }

        public double CalcularPrecioTotalPizza() {
            double sumaPrecios = PrecioXIngredientes() + PrecioXMasa() + PrecioXSalsa();
            return PrecioXTamanio(sumaPrecios)*1.13;
        }
    }
}