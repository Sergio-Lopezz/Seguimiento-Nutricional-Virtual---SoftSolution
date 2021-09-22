using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguimientoNutricional.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recomendacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valoracion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloriasConsumidas = table.Column<int>(type: "int", nullable: false),
                    Estatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Imc = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valoracion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorialRecomendacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroRecomendacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialRecomendacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialRecomendacion_Recomendacion_RegistroRecomendacionId",
                        column: x => x.RegistroRecomendacionId,
                        principalTable: "Recomendacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialValoracion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroValoracionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialValoracion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialValoracion_Valoracion_RegistroValoracionId",
                        column: x => x.RegistroValoracionId,
                        principalTable: "Valoracion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentoIdentidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TajertaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecomendacionId = table.Column<int>(type: "int", nullable: true),
                    Nutricionista_HistorialRecomendacionId = table.Column<int>(type: "int", nullable: true),
                    Nutricionista_HistorialValoracionId = table.Column<int>(type: "int", nullable: true),
                    Latitud = table.Column<int>(type: "int", nullable: true),
                    Longitud = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutricionistaId = table.Column<int>(type: "int", nullable: true),
                    CoachId = table.Column<int>(type: "int", nullable: true),
                    ValoracionId = table.Column<int>(type: "int", nullable: true),
                    HistorialRecomendacionId = table.Column<int>(type: "int", nullable: true),
                    HistorialValoracionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_HistorialRecomendacion_HistorialRecomendacionId",
                        column: x => x.HistorialRecomendacionId,
                        principalTable: "HistorialRecomendacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_HistorialRecomendacion_Nutricionista_HistorialRecomendacionId",
                        column: x => x.Nutricionista_HistorialRecomendacionId,
                        principalTable: "HistorialRecomendacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_HistorialValoracion_HistorialValoracionId",
                        column: x => x.HistorialValoracionId,
                        principalTable: "HistorialValoracion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_HistorialValoracion_Nutricionista_HistorialValoracionId",
                        column: x => x.Nutricionista_HistorialValoracionId,
                        principalTable: "HistorialValoracion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Recomendacion_RecomendacionId",
                        column: x => x.RecomendacionId,
                        principalTable: "Recomendacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Valoracion_ValoracionId",
                        column: x => x.ValoracionId,
                        principalTable: "Valoracion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialRecomendacion_RegistroRecomendacionId",
                table: "HistorialRecomendacion",
                column: "RegistroRecomendacionId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialValoracion_RegistroValoracionId",
                table: "HistorialValoracion",
                column: "RegistroValoracionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_CoachId",
                table: "Persona",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_HistorialRecomendacionId",
                table: "Persona",
                column: "HistorialRecomendacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_HistorialValoracionId",
                table: "Persona",
                column: "HistorialValoracionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Nutricionista_HistorialRecomendacionId",
                table: "Persona",
                column: "Nutricionista_HistorialRecomendacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Nutricionista_HistorialValoracionId",
                table: "Persona",
                column: "Nutricionista_HistorialValoracionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_NutricionistaId",
                table: "Persona",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_RecomendacionId",
                table: "Persona",
                column: "RecomendacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ValoracionId",
                table: "Persona",
                column: "ValoracionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "HistorialRecomendacion");

            migrationBuilder.DropTable(
                name: "HistorialValoracion");

            migrationBuilder.DropTable(
                name: "Recomendacion");

            migrationBuilder.DropTable(
                name: "Valoracion");
        }
    }
}
