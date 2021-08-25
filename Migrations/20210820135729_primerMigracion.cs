using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Disney.Migrations
{
    public partial class primerMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    idGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.idGenero);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    idPersonaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edad = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    peso = table.Column<int>(type: "int", nullable: false),
                    historia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.idPersonaje);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nobreUsu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PeliculasSeries",
                columns: table => new
                {
                    idPeliculaSerie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    calificacion = table.Column<int>(type: "int", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculasSeries", x => x.idPeliculaSerie);
                    table.ForeignKey(
                        name: "FK_PeliculasSeries_Generos_idGenero",
                        column: x => x.idGenero,
                        principalTable: "Generos",
                        principalColumn: "idGenero",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeliculasPerosnajes",
                columns: table => new
                {
                    idPeliculaPersonaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPeliculaSerie = table.Column<int>(type: "int", nullable: false),
                    idPersonaje = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculasPerosnajes", x => x.idPeliculaPersonaje);
                    table.ForeignKey(
                        name: "FK_PeliculasPerosnajes_PeliculasSeries_idPeliculaSerie",
                        column: x => x.idPeliculaSerie,
                        principalTable: "PeliculasSeries",
                        principalColumn: "idPeliculaSerie",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeliculasPerosnajes_Personajes_idPersonaje",
                        column: x => x.idPersonaje,
                        principalTable: "Personajes",
                        principalColumn: "idPersonaje",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasPerosnajes_idPeliculaSerie",
                table: "PeliculasPerosnajes",
                column: "idPeliculaSerie");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasPerosnajes_idPersonaje",
                table: "PeliculasPerosnajes",
                column: "idPersonaje");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasSeries_idGenero",
                table: "PeliculasSeries",
                column: "idGenero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeliculasPerosnajes");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "PeliculasSeries");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
