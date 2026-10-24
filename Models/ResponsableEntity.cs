using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class ResponsableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string DocumentoIdentidad { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Cargo { get; set; } = string.Empty;

        public int DepartamentoId { get; set; }
        [ForeignKey("DepartamentoId")]
        public virtual DepartamentoEntity Departamento { get; set; } = null!;

        public virtual ICollection<AsignacionActivoEntity> Asignaciones { get; set; } = new List<AsignacionActivoEntity>();
    }
}
