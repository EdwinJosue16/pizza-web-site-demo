
namespace CrearMiPizza.Models
{
    public class DetallesIngredientesModel
    {

        public string[] NombresIngredientes = new[] { "Jamón", "Hongos", "Salami", "Peperoni", "Pollo", "Carne molida", "Chorizo", "Tocino", "Queso parmesano", "Queso cheddar", "Cebolla", "Jalapeños" };
        public double[] PreciosIngredientes = new[] { 0.35, 0.17, 0.35, 0.35, 0.51, 0.17, 0.17, 0.85, 0.43, 0.43, 0.09, 0.09 };

        public string [] NombresSalsas = new[] { "Salsa de la casa","Salsa tomate artesanal", "Salsa barbacoa"};
        public double[] PrecioSalsas = new[] { 0.43,0.51,0.35};

        public string[] NombresMasas = new[] { "Original", "Orilla con queso", "Sartén" };
        public double[] PrecioMasas = new[] { 0.51, 0.94, 1.20 };

        public string[] Tamanios = new[] { "Personal (4 slides)", "Mediana (8 slides)", "Grande (16 slides)" };
        public int[] IncrementoPrecioXTamanio = new[] { 1, 2, 4};
    }
}