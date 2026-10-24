using System.ComponentModel.DataAnnotations;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class DepartamentoEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Codigo { get; set; } = string.Empty;

        // Relaciones
        public virtual ICollection<Ubicacione> Ubicaciones { get; set; } = new List<Ubicacione>();
        public virtual ICollection<ResponsableEntity> Responsables { get; set; } = new List<ResponsableEntity>();


    }
}
