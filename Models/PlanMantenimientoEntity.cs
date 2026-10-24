using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class PlanMantenimientoEntity
    {
        [Key]
        public int Id { get; set; }

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual CategoriaActivoEntity Categoria { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Descripcion { get; set; } = string.Empty;

        public int FrecuenciaDias { get; set; }

        [MaxLength(50)]
        public string Tipo { get; set; } = string.Empty; // Preventivo / Predictivo

        public virtual ICollection<MantenimientoEntity> Mantenimientos { get; set; } = new List<MantenimientoEntity>();
    }
}
