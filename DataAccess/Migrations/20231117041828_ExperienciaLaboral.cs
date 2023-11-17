using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExperienciaLaboral : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstudiosAcademicos",
                columns: table => new
                {
                    EntidadEmisora = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    TituloObtenido = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudiosAcademicos", x => x.EntidadEmisora);
                });

            migrationBuilder.CreateTable(
                name: "ExperienciaLaboral",
                columns: table => new
                {
                    EperienciaLaboralID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntidadTrabajo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", maxLength: 1000, nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    CandidatoID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciaLaboral", x => x.EperienciaLaboralID);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesAceptadas",
                columns: table => new
                {
                    SolicitudAceptadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAceptacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    SolicitudID = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesAceptadas", x => x.SolicitudAceptadaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudiosAcademicos");

            migrationBuilder.DropTable(
                name: "ExperienciaLaboral");

            migrationBuilder.DropTable(
                name: "SolicitudesAceptadas");
        }
    }
}
