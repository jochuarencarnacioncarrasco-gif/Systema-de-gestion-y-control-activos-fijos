using Microsoft.EntityFrameworkCore;

namespace Systema_de_gestion_y_control_activos_fijos.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {}

        public DbSet <ActivoEntity> ActivoFijo { get; set; }

        public DbSet<AlertaEntity> Alerta { get; set; }

        public DbSet<AsignacionActivoEntity> AsignacionActivo { get; set; }

        public DbSet<AuditoriaEntity> Auditoria { get; set; }

        public DbSet<BajaActivoEntity> BajaActivo { get; set; }
        public DbSet<DepartamentoEntity> Departamento { get; set; }

        public DbSet<DetalleInventarioFisicoEntity> DetalleInventarioFisicos { get; set; }

        public DbSet<DocumentoActivoEntity> DocumentoActivos { get; set; }

        public DbSet<EstadoActivo> EstadoActivos { get; set; }

        public DbSet<IncidenciasEntity> Incidencias { get; set; }

        public DbSet<InventarioFisicoEntity> InventarioFisico { get; set; }

        public DbSet<LecturaActivoEntity> LecturaActivos { get; set; }

        public DbSet<MantenimientoEntity> Mantenimientos { get; set; }

        public DbSet<PermisosEntity> Permisos { get; set; }

        public DbSet<PlanMantenimientoEntity> PlanMantenimientos { get; set; }

        public DbSet<ProveedorEntity> Proveedores { get; set; }

        public DbSet<Ubicacione> Ubicaciones { get; set; }

        public DbSet<ResponsableEntity> Responsables { get; set; }  

        public DbSet<UsuarioEntity> Usuarios { get; set; }


        public DbSet<RolPermiso> rolPermisos { get; set; }

        public DbSet<RolesEntity> Roles { get; set; }

        public DbSet<MovimientoEntity> Movimientos { get; set; }

        public DbSet<CategoriaActivoEntity> CategoriaActivos { get; set; }

        public DbSet<LoginEntity> Login { get; set; }








    }

}
