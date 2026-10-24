using System;
using System.ComponentModel.DataAnnotations;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class EstadoActivo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty; // Ej: Operativo, En Reparación, De Baja

        // Relaciones
        public virtual ICollection<ActivoEntity> Activos { get; set; } = new List<ActivoEntity>();
    }
}

