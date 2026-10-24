using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class DetalleInventarioFisicoEntity
    {
        [Key]
        public int IdDetalleFisico { get; set; }
        public int InventarioFisicoId { get; set; }
        [ForeignKey("InventarioFisicoId")]
        public virtual InventarioFisicoEntity InventarioFisico { get; set; } = null!;

        public int ActivoId { get; set; }
        [ForeignKey("ActivoId")]
        public virtual ActivoEntity Activo { get; set; } = null!;

        public bool Encontrado { get; set; } = false;

        [MaxLength(250)]
        public string Observacion { get; set; } = string.Empty;
    }
}
