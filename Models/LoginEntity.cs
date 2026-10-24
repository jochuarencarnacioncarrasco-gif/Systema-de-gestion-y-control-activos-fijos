using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class LoginEntity
    {
        [Key]
        public int IdLogin { get; set; }

        [Required(ErrorMessage = "El correo o nombre de usuario es obligatorio.")]
        [StringLength(100, ErrorMessage = "El usuario no puede superar los 100 caracteres.")]
        public string? Usuario { get; set; } // O CorreoElectronico

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(255, ErrorMessage = "La contraseña excede el tamaño permitido.")]
        [DataType(DataType.Password)]
        public string? Contrasena { get; set; } // Almacenada preferiblemente hasheada (ej. BCrypt, SHA256)

        public DateTime? UltimoAcceso { get; set; }

        public bool Activo { get; set; } = true; // Para bloquear el acceso si es necesario

        // Relación Opcional / Uno a Uno (o Uno a Muchos) con la entidad Usuario
        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public virtual UsuarioEntity? UsuarioNav { get; set; }
    }
}
