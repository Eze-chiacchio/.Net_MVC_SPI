using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vapos2.Migrations
{
    public partial class Vapos2ContextRegistrosContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    nombreApe = table.Column<string>(nullable: false),
                    telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.nombreApe);
                });

            migrationBuilder.CreateTable(
                name: "Vapos",
                columns: table => new
                {
                    IdVapo = table.Column<string>(nullable: false),
                    Intecambiador_Izq = table.Column<int>(nullable: false),
                    Intecambiador_Der = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vapos", x => x.IdVapo);
                });

            migrationBuilder.CreateTable(
                name: "Registos",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    IdVapo = table.Column<string>(nullable: true),
                    nombreApe = table.Column<string>(nullable: true),
                    Prueba_Hidráulica = table.Column<bool>(nullable: false),
                    Prueba_Estanqueidad = table.Column<bool>(nullable: false),
                    Prueba_Funcionamiento = table.Column<bool>(nullable: false),
                    Detalles = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registos", x => x.IdRegistro);
                    table.ForeignKey(
                        name: "FK_Registos_Vapos_IdVapo",
                        column: x => x.IdVapo,
                        principalTable: "Vapos",
                        principalColumn: "IdVapo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registos_Personas_nombreApe",
                        column: x => x.nombreApe,
                        principalTable: "Personas",
                        principalColumn: "nombreApe",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registos_IdVapo",
                table: "Registos",
                column: "IdVapo");

            migrationBuilder.CreateIndex(
                name: "IX_Registos_nombreApe",
                table: "Registos",
                column: "nombreApe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registos");

            migrationBuilder.DropTable(
                name: "Vapos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
