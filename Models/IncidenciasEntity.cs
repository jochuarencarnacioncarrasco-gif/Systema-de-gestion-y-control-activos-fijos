using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class IncidenciasEntity
    {
        [Key]
    public int IncidenciaId { get; set; }

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public ActivoEntity Activo { get; set; } = null!;

        public int? ReportadoPorId { get; set; }
        [ForeignKey("ReportadoPorId")]
        public UsuarioEntity? ReportadoPor { get; set; }

        [MaxLength(150)]
        public string? ReportanteNombre { get; set; }

        [Required, MaxLength(150)]
        public string Titulo { get; set; } = null!;

        [Required, MaxLength(1000)]
        public string Descripcion { get; set; } = null!;

        [Required, MaxLength(20)]
        public string Prioridad { get; set; } = "Media"; // Baja, Media, Alta, Critica

        [Required, MaxLength(20)]
        public string Estado { get; set; } = "Abierta"; // Abierta, EnAtencion, Resuelta, Cerrada

        public DateTime FechaReporte { get; set; } = DateTime.UtcNow;
        public DateTime? FechaCierre { get; set; }

        [MaxLength(1000)]
        public string? Solucion { get; set; }

        public ICollection<MantenimientoEntity> Mantenimientos { get; set; } = new List<MantenimientoEntity>();
    }
}
