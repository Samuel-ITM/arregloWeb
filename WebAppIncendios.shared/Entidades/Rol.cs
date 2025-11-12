using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebAppIncendios.Shared.Entidades;

namespace WebAppIncendios.shared.Entidades
{
    public  class Rol
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del rol")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Descripción del rol")]
        [StringLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        public string? Descripcion { get; set; }

        [Display(Name = "Nivel de acceso")]
        [Range(1, 10, ErrorMessage = "El nivel de acceso debe estar entre 1 y 10.")]
        public int NivelAcceso { get; set; } = 1;

        [Display(Name = "Activo")]
        public bool Activo { get; set; } = true;

        [JsonIgnore]
        public ICollection<Empleado>? Empleados { get; set; }
    }
}
