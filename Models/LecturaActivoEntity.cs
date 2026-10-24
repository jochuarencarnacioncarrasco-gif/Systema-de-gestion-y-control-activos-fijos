using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class LecturaActivoEntity
    {
        [Key]
        public int Id { get; set; }

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public virtual ActivoEntity Activo { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string TipoLectura { get; set; } = string.Empty; // Temperatura, Vibración, etc.

        public double Valor { get; set; }

        public DateTime FechaLectura { get; set; } = DateTime.Now;
    }
}
