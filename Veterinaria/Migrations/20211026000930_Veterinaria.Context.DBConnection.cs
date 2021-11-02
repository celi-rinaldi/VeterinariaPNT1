using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.Migrations
{
    public partial class VeterinariaContextDBConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    nroTurno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    horario = table.Column<double>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    dni = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.nroTurno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turnos");
        }
    }
}
