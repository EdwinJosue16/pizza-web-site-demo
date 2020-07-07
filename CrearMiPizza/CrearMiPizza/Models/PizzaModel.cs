using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrearMiPizza.Models
{
    public class PizzaModel
    {
        public int[] IngredientesId { get; set; }
        public string Tamanios { get; set; }
        public string TipoSalsa { get; set; }
        public string TipoMasa { get; set; }
        public string DireccionEntrega { get; set; }
        public string NombreDuenioPizza { get; set;}
        public string TelefonoEntrega {get; set;}
    }
}