using System.ComponentModel.DataAnnotations;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
  
    public class PermisosEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Modulo { get; set; } = string.Empty;

        // Relaciones
        public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
    }
}
