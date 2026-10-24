using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class MantenimientoEntity
    {
        [Key]
        
        public int Id { get; set; }

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public virtual ActivoEntity Activo { get; set; } = null!;

        public int? PlanMantenimientoId { get; set; }
        [ForeignKey("PlanMantenimientoId")]
        public virtual PlanMantenimientoEntity? PlanMantenimiento { get; set; }

        public DateTime FechaProgramada { get; set; }
        public DateTime? FechaEjecucion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Costo { get; set; }

        [MaxLength(500)]
        public string Diagnostico { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Estado { get; set; } = string.Empty;
    }
}
