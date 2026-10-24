using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class Ubicacione
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Edificio { get; set; } = string.Empty;

        public int DepartamentoId { get; set; }
        [ForeignKey("DepartamentoId")]
        public virtual DepartamentoEntity Departamento { get; set; } = null!;

        // Relaciones
        public virtual ICollection<ActivoEntity> Activos { get; set; } = new List<ActivoEntity>();
    }
}
