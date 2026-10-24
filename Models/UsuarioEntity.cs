using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class UsuarioEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public int RolId { get; set; }
        [ForeignKey("RolId")]
        public virtual RolesEntity Rol { get; set; } = null!;

        public bool Activo { get; set; } = true;

        // Relaciones
        public virtual ICollection<AuditoriaEntity> Auditorias { get; set; } = new List<AuditoriaEntity>();
    }
}
