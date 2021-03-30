using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudUsuarios.Migrations
{
    public partial class SincronizarDataBaseInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alumno",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    nombre = table.Column<string>(type: "varchar(29)", unicode: false, maxLength: 29, nullable: true),
					apellidoP = table.Column<string>(type: "varchar(29)", unicode: false, maxLength: 29, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alumno");
        }
    }
}
