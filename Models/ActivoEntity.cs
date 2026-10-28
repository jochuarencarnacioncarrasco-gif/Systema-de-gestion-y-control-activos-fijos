using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{

    
    public class ActivoEntity

    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CodigoInventario { get; set; } = string.Empty;

        [MaxLength(50)]
        public string NumeroSerie { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Descripcion { get; set; } = string.Empty;

        public DateTime FechaAdquisicion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoAdquisicion { get; set; }

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual CategoriaActivoEntity Categoria { get; set; } = null!;

        public int UbicacionId { get; set; }
        [ForeignKey("UbicacionId")]
        public virtual Ubicacione Ubicacion { get; set; } = null!;

        public int EstadoId { get; set; }
        [ForeignKey("EstadoId")]
        public virtual EstadoActivo EstadoActivo { get; set; } = null!;

        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public virtual ProveedorEntity Proveedor { get; set; } = null!;

        // Relaciones con colecciones
        public virtual ICollection<AsignacionActivoEntity> Asignaciones { get; set; } = new List<AsignacionActivoEntity>();
        public virtual ICollection<MovimientoEntity> Movimientos { get; set; } = new List<MovimientoEntity>();
        public virtual ICollection<MantenimientoEntity> Mantenimientos { get; set; } = new List<MantenimientoEntity>();
        public virtual ICollection<LecturaActivoEntity> Lecturas { get; set; } = new List<LecturaActivoEntity>();
        public virtual ICollection<AlertaEntity> Alertas { get; set; } = new List<AlertaEntity>();
        public virtual ICollection<DocumentoActivoEntity> Documentos { get; set; } = new List<DocumentoActivoEntity>();
        public virtual ICollection<DetalleInventarioFisicoEntity> DetalleInventarios { get; set; } = new List<DetalleInventarioFisicoEntity>();
        public virtual ICollection<BajaActivoEntity> Bajas { get; set; } = new List<BajaActivoEntity>();
    }
}

