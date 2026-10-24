using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class AlertaEntity
    {
        [Key]
        public int Id { get; set; }

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public virtual ActivoEntity Activo { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Mensaje { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Nivel { get; set; } = string.Empty; // Info, Advertencia, Crítico

        public DateTime FechaAlerta { get; set; } = DateTime.Now;

        public bool Atendida { get; set; } = false;
    }
}
