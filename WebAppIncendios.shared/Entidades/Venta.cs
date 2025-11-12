using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAppIncendios.Shared.Entidades
{
    public class Venta
    {
        
        public int Id { get; set; }

        [Display(Name = "Fecha de la venta")]
        [Required]
        public DateTime FechaVenta { get; set; }

        [Display(Name = "Total de la venta")]
        [Range(1000, 100000000, ErrorMessage = "El total debe estar entre {1} y {2}.")]
        public decimal Total { get; set; }

        [Display(Name = "Método de pago")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [RegularExpression("Efectivo|Tarjeta|Transferencia", ErrorMessage = "Debe ser Efectivo, Tarjeta o Transferencia.")]
        public string MetodoPago { get; set; }


        public int ClienteId { get; set; }
        [JsonIgnore]
        public Cliente? Cliente { get; set; }

        public int EmpleadoId { get; set; }
        [JsonIgnore]
        public Empleado? Empleado { get; set; }
        [JsonIgnore]
        public ICollection<Dispositivo>? Dispositivos { get; set; }
    }
}

