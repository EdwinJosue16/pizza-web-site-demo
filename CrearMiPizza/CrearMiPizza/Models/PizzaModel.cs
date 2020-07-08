using System.ComponentModel.DataAnnotations;

namespace CrearMiPizza.Models
{
    public class PizzaModel
    {
        public int [] IngredientesId { get; set; }
        public int Tamanio { get; set; }
        public int TipoSalsa { get; set; }
        public int TipoMasa { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "El nombre de la ciudad no puede superar los 30 caracteres")]
        [Required(ErrorMessage = "Es necesario que indique la ciudad de entrega")]
        [Display(Name = "Ingrese la ciudad de entrega")]
        public string CiudadEntrega { get; set; }

        [StringLength(100, MinimumLength = 1, ErrorMessage = "La dirección no puede superar los 100 caracteres")]
        [Required (ErrorMessage ="Es necesario que indique la dirección de entrega")]
        [Display(Name = "Ingrese la dirección de entrega")]
        public string DireccionEntrega { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "El nombre completo no puede superar los 30 caracteres")]
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