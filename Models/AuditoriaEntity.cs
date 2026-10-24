using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class AuditoriaEntity
    {
        [Key]
        public int Id { get; set; }

        public int? UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual UsuarioEntity? Usuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string Accion { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string TablaAfectada { get; set; } = string.Empty;

        public DateTime Fecha { get; set; } = DateTime.Now;

        public string Detalles { get; set; } = string.Empty;
    }
}
