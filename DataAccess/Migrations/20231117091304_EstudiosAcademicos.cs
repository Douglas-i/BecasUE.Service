using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EstudiosAcademicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstudiosAcademicos",
                columns: table => new
                {
                    EstudiosAcademicosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TituloObtenido = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    EntidadEmisora = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CandidatoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudiosAcademicos", x => x.EstudiosAcademicosId);
                });

            migrationBuilder.CreateTable(
                name: "ExperienciaLaboral",
                columns: table => new
                {
                    ExperienciaLaboralID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntidadTrabajo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CandidatoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciaLaboral", x => x.ExperienciaLaboralID);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesAceptadas",
                columns: table => new
                {
                    SolicitudAceptadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudID = table.Column<int>(type: "int", nullable: false),
                    FechaAceptacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesAceptadas", x => x.SolicitudAceptadaId);
                });

            migrationBuilder.CreateTable(
                name: "TiposEspecialidad",
                columns: table => new
                {
                    TipoEspecialidadID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoEspecialidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEspecialidad", x => x.TipoEspecialidadID);
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

            migrationBuilder.DropTable(
                name: "TiposEspecialidad");
        }
    }
}
