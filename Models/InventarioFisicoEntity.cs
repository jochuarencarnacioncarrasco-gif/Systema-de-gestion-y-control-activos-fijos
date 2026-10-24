using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class InventarioFisicoEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descripcion { get; set; } = string.Empty;

        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime? FechaFin { get; set; }

        [MaxLength(50)]
        public string Estado { get; set; } = string.Empty; // Abierto, Cerrado

        public virtual ICollection<DetalleInventarioFisicoEntity> DetalleInventarios { get; set; } = new List<DetalleInventarioFisicoEntity>();
    }
}
