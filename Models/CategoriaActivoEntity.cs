using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class CategoriaActivoEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(250)]
        public string Descripcion { get; set; } = string.Empty;

        // Relaciones
        public virtual ICollection<ActivoEntity> Activos { get; set; } = new List<ActivoEntity>();
        public virtual ICollection<PlanMantenimientoEntity> PlanesMantenimiento { get; set; } = new List<PlanMantenimientoEntity>();
    }
}

