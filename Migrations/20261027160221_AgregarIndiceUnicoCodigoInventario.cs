using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Systema_de_gestion_y_control_activos_fijos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarIndiceUnicoCodigoInventario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ActivoFijo_CodigoInventario",
                table: "ActivoFijo",
                column: "CodigoInventario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ActivoFijo_CodigoInventario",
                table: "ActivoFijo");
        }
    }
}
