using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class AsignacionActivoEntity
    {
        [Key]
        public int Id { get; set; }

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public virtual ActivoEntity Activo { get; set; } = null!;

        public int ResponsableId { get; set; }
        [ForeignKey("ResponsableId")]
        public virtual ResponsableEntity Responsable { get; set; } = null!;

        public DateTime FechaAsignacion { get; set; } = DateTime.Now;
        public DateTime? FechaDevolucionEstimada { get; set; }

        [MaxLength(250)]
        public string Observaciones { get; set; } = string.Empty;
    }
    }

