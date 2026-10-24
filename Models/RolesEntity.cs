using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class RolesEntity
    
     {
    [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Descripcion { get; set; } = string.Empty;

        // Relaciones
        public virtual ICollection<UsuarioEntity> Usuarios { get; set; } = new List<UsuarioEntity>();
        public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
    }

}

