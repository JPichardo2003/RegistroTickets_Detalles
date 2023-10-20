using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroTickets_Detalles.Server.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoAcentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Clientes",
                newName: "Teléfono");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Clientes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Clientes",
                newName: "Dirección");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Teléfono",
                table: "Clientes",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Clientes",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "Dirección",
                table: "Clientes",
                newName: "Direccion");
        }
    }
}
