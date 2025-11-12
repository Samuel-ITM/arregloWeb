using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebAppIncendios.shared.Entidades;

namespace WebAppIncendios.Shared.Entidades
{
    public class Cita
    {
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(10)]
        public string Hora { get; set; }

        [StringLength(100)]
        public string Motivo { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        public int ClienteId { get; set; }
        [JsonIgnore]
        public Cliente? Cliente { get; set; }

        public int EmpleadoId { get; set; }
        
        [JsonIgnore]
        public Empleado? Empleado { get; set; }
    }
}

