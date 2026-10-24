using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class RolPermiso
    {
        [Key]
        public int IdRolPermiso { get; set; }
        public int RolId { get; set; }
        [ForeignKey("RolId")]
        public virtual RolesEntity Rol { get; set; } = null!;

        public int PermisoId { get; set; }
        [ForeignKey("PermisoId")]
        public virtual PermisosEntity Permiso { get; set; } = null!;


    }
}
