using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProgramasTitulacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ProgramasTitulacion_EspecialidadId",
                table: "ProgramasTitulacion",
                column: "EspecialidadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramasTitulacion");

            migrationBuilder.DropTable(
                name: "TiposEspecialidad");
        }
    }
}
