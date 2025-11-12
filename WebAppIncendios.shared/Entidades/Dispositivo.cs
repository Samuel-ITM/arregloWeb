using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAppIncendios.Shared.Entidades
{
    public class Dispositivo
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Display(Name = "Tipo de dispositivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [RegularExpression("Extintor|Sensor de humo|Rociador|Alarma", ErrorMessage = "Debe ser Extintor, Sensor de humo, Rociador o Alarma.")]
        public string Tipo { get; set; }

        [Display(Name = "Precio unitario")]
        [Range(1000, 10000000, ErrorMessage = "El precio debe estar entre {1} y {2}.")]
        public decimal Precio { get; set; }

        [Display(Name = "Stock disponible")]
        [Range(0, 5000, ErrorMessage = "El stock debe estar entre {1} y {2}.")]
        public int Stock { get; set; }

        [Display(Name = "Fecha de fabricación")]
        public DateTime FechaFabricacion { get; set; }

        [Display(Name = "Proveedor")]
        [Required]
        public int IdProveedor { get; set; }
        [JsonIgnore]
        public Proveedor? Proveedor { get; set; }
    }
}