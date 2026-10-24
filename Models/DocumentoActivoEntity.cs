using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class DocumentoActivoEntity
    {
        [Key]
        public int Id { get; set; }

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public virtual ActivoEntity Activo { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string NombreArchivo { get; set; } = string.Empty;

        [Required]
        [MaxLength(250)]
        public string Ruta { get; set; } = string.Empty;

        public DateTime FechaSubida { get; set; } = DateTime.Now;
    }
}
