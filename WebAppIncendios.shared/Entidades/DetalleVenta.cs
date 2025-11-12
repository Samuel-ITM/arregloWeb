using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAppIncendios.Shared.Entidades
{
    public class DetalleVenta
    {
        public int Id{ get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Producto { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(1, 1000, ErrorMessage = "La cantidad debe estar entre {1} y {2}.")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio unitario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(0.01, 100000, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal PrecioUnitario { get; set; }

        [Display(Name = "Total")]
        public decimal Total => Cantidad * PrecioUnitario;

        [Display(Name = "Usuario responsable")]
        [Required(ErrorMessage = "Debe asociar un usuario.")]
        public int IdUsuario { get; set; }
        [JsonIgnore]
        public Cliente Cliente { get; set; }
    }
}

