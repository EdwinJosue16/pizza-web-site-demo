
namespace CrearMiPizza.Models
{
    public class DetallesIngredientesModel
    {

        public string[] NombresIngredientes = new[] { "Jamón", "Hongos", "Salami", "Peperoni", "Pollo", "Carne molida", "Chorizo", "Tosino", "Queso parmesano", "Queso cheddar", "Cebolla", "Jalapeños" };
        public int[] PreciosIngredientes = new[] { 200, 100, 200, 200, 300, 100, 100, 500, 250, 250, 50, 50 };

        public string [] NombresSalsas = new[] { "Salsa de la casa","Salsa tomate artesanal", "Salsa barbacoa"};
        public int[] PrecioSalsas = new[] { 250,300,200};

        public string[] NombresMasas = new[] { "Original", "Orilla con queso", "Sartén" };
        public int[] PrecioMasas = new[] { 300, 550, 700 };

        public string[] Tamanios = new[] { "Personal (4 slides)", "Mediana (8 slides)", "Grande (16 slides)" };
        public int[] IncrementoPrecioXTamanio = new[] { 1, 2, 4};
    }
}