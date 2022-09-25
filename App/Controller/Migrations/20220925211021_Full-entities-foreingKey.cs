using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Controller.Migrations
{
    public partial class FullentitiesforeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colegios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nit = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    razonSocial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colegios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    secretaria = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Patrocinadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    tipoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrocinadores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    disciplina = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fechaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    municipioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Torneos_Municipios_municipioId",
                        column: x => x.municipioId,
                        principalTable: "Municipios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    disciplina = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patrocinadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Equipos_Patrocinadores_patrocinadorId",
                        column: x => x.patrocinadorId,
                        principalTable: "Patrocinadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instalaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ubicacion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    capacidad = table.Column<int>(type: "int", nullable: false),
                    torneoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instalaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Instalaciones_Torneos_torneoId",
                        column: x => x.torneoId,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jueces",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    torneoId = table.Column<int>(type: "int", nullable: false),
                    colegioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jueces", x => x.id);
                    table.ForeignKey(
                        name: "FK_Jueces_Colegios_colegioId",
                        column: x => x.colegioId,
                        principalTable: "Colegios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jueces_Torneos_torneoId",
                        column: x => x.torneoId,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deportistas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    eps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    residencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deportistas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Deportistas_Equipos_equipoID",
                        column: x => x.equipoID,
                        principalTable: "Equipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrenadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Entrenadores_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TorneosEquipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    torneoId = table.Column<int>(type: "int", nullable: false),
                    equipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TorneosEquipos", x => x.id);
                    table.ForeignKey(
                        name: "FK_TorneosEquipos_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TorneosEquipos_Torneos_torneoId",
                        column: x => x.torneoId,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escenarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    disciplina = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    capacidad = table.Column<int>(type: "int", nullable: false),
                    instalacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escenarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Escenarios_Instalaciones_instalacionId",
                        column: x => x.instalacionId,
                        principalTable: "Instalaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deportistas_equipoID",
                table: "Deportistas",
                column: "equipoID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_equipoId",
                table: "Entrenadores",
                column: "equipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_patrocinadorId",
                table: "Equipos",
                column: "patrocinadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Escenarios_instalacionId",
                table: "Escenarios",
                column: "instalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Instalaciones_torneoId",
                table: "Instalaciones",
                column: "torneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jueces_colegioId",
                table: "Jueces",
                column: "colegioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jueces_torneoId",
                table: "Jueces",
                column: "torneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_municipioId",
                table: "Torneos",
                column: "municipioId");

            migrationBuilder.CreateIndex(
                name: "IX_TorneosEquipos_equipoId",
                table: "TorneosEquipos",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_TorneosEquipos_torneoId",
                table: "TorneosEquipos",
                column: "torneoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deportistas");

            migrationBuilder.DropTable(
                name: "Entrenadores");

            migrationBuilder.DropTable(
                name: "Escenarios");

            migrationBuilder.DropTable(
                name: "Jueces");

            migrationBuilder.DropTable(
                name: "TorneosEquipos");

            migrationBuilder.DropTable(
                name: "Instalaciones");

            migrationBuilder.DropTable(
                name: "Colegios");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Torneos");

            migrationBuilder.DropTable(
                name: "Patrocinadores");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
