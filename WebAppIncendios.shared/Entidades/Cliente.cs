using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebAppIncendios.shared.Entidades;

namespace WebAppIncendios.Shared.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del cliente")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido.")]
        public string Correo { get; set; }

        [Display(Name = "Teléfono")]
        [Required]
        [RegularExpression(@"^\d{7,15}$", ErrorMessage = "El número debe tener entre 7 y 15 dígitos.")]
        public string Telefono { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(200)]
        public string? Direccion { get; set; }

        [JsonIgnore]
        public ICollection<Cita>? Citas { get; set; }
        [JsonIgnore]
        public ICollection<Venta>? Ventas { get; set; }
    }
}

