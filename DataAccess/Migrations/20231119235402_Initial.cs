using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfertaAnual",
                columns: table => new
                {
                    OfertaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Año = table.Column<int>(type: "int", nullable: false),
                    FechaApertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroUniversidades = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaisSedePrograma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfertaAnual", x => x.OfertaID);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApellidoPersona = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PaísPrecedencia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pasaporte = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaID);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRol = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolID);
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

            migrationBuilder.CreateTable(
                name: "Universidad",
                columns: table => new
                {
                    universidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    universidadNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    pais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universidad", x => x.universidadId);
                });

            migrationBuilder.CreateTable(
                name: "EstudiosAcademicos",
                columns: table => new
                {
                    EstudiosAcademicosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TituloObtenido = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    EntidadEmisora = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudiosAcademicos", x => x.EstudiosAcademicosID);
                    table.ForeignKey(
                        name: "FK_EstudiosAcademicos_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienciaLaboral",
                columns: table => new
                {
                    ExperienciaLaboralID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntidadTrabajo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciaLaboral", x => x.ExperienciaLaboralID);
                    table.ForeignKey(
                        name: "FK_ExperienciaLaboral_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaCreación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaModificación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioID);
                    table.ForeignKey(
                        name: "FK_Usuario_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramasTitulacion",
                columns: table => new
                {
                    ProgramaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TituloPrograma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadCredito = table.Column<int>(type: "int", nullable: false),
                    NumeroDiplomados = table.Column<int>(type: "int", nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramasTitulacion", x => x.ProgramaId);
                    table.ForeignKey(
                        name: "FK_ProgramasTitulacion_TiposEspecialidad_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "TiposEspecialidad",
                        principalColumn: "TipoEspecialidadID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramasOfertados",
                columns: table => new
                {
                    ProgramaOfertadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalazacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoAprobado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Financiamiento = table.Column<int>(type: "int", nullable: false),
                    ProgramaId = table.Column<int>(type: "int", nullable: false),
                    OfertaId = table.Column<int>(type: "int", nullable: false),
                    UniversidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramasOfertados", x => x.ProgramaOfertadoId);
                    table.ForeignKey(
                        name: "FK_ProgramasOfertados_OfertaAnual_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "OfertaAnual",
                        principalColumn: "OfertaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramasOfertados_ProgramasTitulacion_ProgramaId",
                        column: x => x.ProgramaId,
                        principalTable: "ProgramasTitulacion",
                        principalColumn: "ProgramaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramasOfertados_Universidad_UniversidadId",
                        column: x => x.UniversidadId,
                        principalTable: "Universidad",
                        principalColumn: "universidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesProgramas",
                columns: table => new
                {
                    SolicitudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resumen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    ProgramaOfertadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesProgramas", x => x.SolicitudId);
                    table.ForeignKey(
                        name: "FK_SolicitudesProgramas_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudesProgramas_ProgramasOfertados_ProgramaOfertadoId",
                        column: x => x.ProgramaOfertadoId,
                        principalTable: "ProgramasOfertados",
                        principalColumn: "ProgramaOfertadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesAceptadas",
                columns: table => new
                {
                    SolicitudAceptadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAceptacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolicitudID = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesAceptadas", x => x.SolicitudAceptadaId);
                    table.ForeignKey(
                        name: "FK_SolicitudesAceptadas_SolicitudesProgramas_SolicitudID",
                        column: x => x.SolicitudID,
                        principalTable: "SolicitudesProgramas",
                        principalColumn: "SolicitudId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudiosAcademicos_PersonaID",
                table: "EstudiosAcademicos",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienciaLaboral_PersonaID",
                table: "ExperienciaLaboral",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramasOfertados_OfertaId",
                table: "ProgramasOfertados",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramasOfertados_ProgramaId",
                table: "ProgramasOfertados",
                column: "ProgramaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramasOfertados_UniversidadId",
                table: "ProgramasOfertados",
                column: "UniversidadId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramasTitulacion_EspecialidadId",
                table: "ProgramasTitulacion",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesAceptadas_SolicitudID",
                table: "SolicitudesAceptadas",
                column: "SolicitudID");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesProgramas_PersonaId",
                table: "SolicitudesProgramas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesProgramas_ProgramaOfertadoId",
                table: "SolicitudesProgramas",
                column: "ProgramaOfertadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PersonaId",
                table: "Usuario",
                column: "PersonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudiosAcademicos");

            migrationBuilder.DropTable(
                name: "ExperienciaLaboral");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "SolicitudesAceptadas");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "SolicitudesProgramas");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "ProgramasOfertados");

            migrationBuilder.DropTable(
                name: "OfertaAnual");

            migrationBuilder.DropTable(
                name: "ProgramasTitulacion");

            migrationBuilder.DropTable(
                name: "Universidad");

            migrationBuilder.DropTable(
                name: "TiposEspecialidad");
        }
    }
}
