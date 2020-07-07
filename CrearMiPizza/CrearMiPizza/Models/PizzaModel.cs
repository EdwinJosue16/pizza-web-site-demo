using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required (ErrorMessage ="Es necesario que indique la dirección de entrega")]
        [Display(Name = "Ingrese la dirección de entrega")]
        public string DireccionEntrega { get; set; }

        [Required(ErrorMessage = "Es necesario que indique su nombre")]
        [Display(Name ="Ingrese su nombre completo")]
        public string NombreDuenioPizza { get; set;}

        [Required(ErrorMessage = "Es necesario que indique su número de teléfono")]
        [Display(Name = "Ingrese su número de teléfono")]
        public string TelefonoEntrega {get; set;}
    }
}