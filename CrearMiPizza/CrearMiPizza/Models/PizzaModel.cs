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


        [Required(ErrorMessage = "Es necesario que indique la ciudad de entrega")]
        [Display(Name = "Ingrese la ciudad de entrega")]
        public string CiudadEntrega { get; set; }

        [Required (ErrorMessage ="Es necesario que indique la dirección de entrega")]
        [Display(Name = "Ingrese la dirección de entrega")]
        public string DireccionEntrega { get; set; }

        [Required(ErrorMessage = "Es necesario que indique su nombre")]
        [Display(Name ="Ingrese su nombre completo")]
        public string NombreDuenioPizza { get; set;}

        [StringLength(8, MinimumLength = 8,ErrorMessage ="El número de teléfono debe tener 8 digitos")]
        [RegularExpression("^[0-9]*$",ErrorMessage = "El formato de ingreso es Ej: 22334455")]
        [Required(ErrorMessage = "Es necesario que indique su número de teléfono")]
        [Display(Name = "Ingrese su número de teléfono")]
        public string TelefonoEntrega {get; set;}
    }
}