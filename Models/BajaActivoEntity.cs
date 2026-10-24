using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class BajaActivoEntity
    {

        [Key]
        public int Id { get; set; }

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public virtual ActivoEntity Activo { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string MotivoBaja { get; set; } = string.Empty;

        public DateTime FechaBaja { get; set; } = DateTime.Now;

        [MaxLength(250)]
        public string DocumentoRespaldo { get; set; } = string.Empty;

    }
}
