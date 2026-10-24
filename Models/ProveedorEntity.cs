using System;
using System.ComponentModel.DataAnnotations;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class ProveedorEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(50)]
        public string RncNit { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Telefono { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Correo { get; set; } = string.Empty;

        // Relaciones
        public virtual ICollection<ActivoEntity> Activos { get; set; } = new List<ActivoEntity>();
    }
}
