using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class AdicionandoApellidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrimerApellido",
                table: "Estudiante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Estudiante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimerApellido",
                table: "Empleado",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Empleado",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimerApellido",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "PrimerApellido",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Empleado");
        }
    }
}
