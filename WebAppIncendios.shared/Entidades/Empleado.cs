using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebAppIncendios.shared.Entidades;

namespace WebAppIncendios.Shared.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }

        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(120)]
        public string Nombre { get; set; }


        [Display(Name = "Correo")]
        [Required]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido.")]
        public string Correo { get; set; }

        [Display(Name = "Teléfono")]
        [RegularExpression(@"^\d{7,15}$", ErrorMessage = "El número debe tener entre 7 y 15 dígitos.")]
        public string? Telefono { get; set; }

        [Display(Name = "Horario de visitas")]
        [MaxLength(100)]
        public string? HorarioVisitas { get; set; }

        [Display(Name = "Estado del empleado")]
        [RegularExpression("Activo|Inactivo", ErrorMessage = "Debe ser Activo o Inactivo.")]
        public string Estado { get; set; } = "Activo";

        public int RolId { get; set; }
        [JsonIgnore]
        public Rol? Rol { get; set; }

        [JsonIgnore]
        public ICollection<Cita>? Citas { get; set; }
    }
}