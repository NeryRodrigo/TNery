using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonaAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_completo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nro_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo_electronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
