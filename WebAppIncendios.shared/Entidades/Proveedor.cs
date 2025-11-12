using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebAppIncendios.shared.Entidades;

namespace WebAppIncendios.Shared.Entidades
{
    public class Proveedor
    {
        public int Id{ get; set; }

        [Display(Name = "Nombre del proveedor")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido.")]
        public string Correo { get; set; }

        [Display(Name = "Teléfono de contacto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [RegularExpression(@"^\d{7,15}$", ErrorMessage = "El número debe tener entre 7 y 15 dígitos.")]
        public string Telefono { get; set; }

        [Display(Name = "Dirección del proveedor")]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string? Direccion { get; set; }

        [Display(Name = "Productos que suministra")]
        [MaxLength(300)]
        public string? Productos { get; set; }

        [JsonIgnore]
        public ICollection<Dispositivo>? Dispositivos { get; set; }
    }
}

