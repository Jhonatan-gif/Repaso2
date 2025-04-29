using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repaso2.Migrations
{
    /// <inheritdoc />
    public partial class MigracionCorregida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesor_Materia_MateriaId",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Profesor_MateriaId",
                table: "Profesor");

            migrationBuilder.DropColumn(
                name: "MateriaId",
                table: "Profesor");

            migrationBuilder.CreateTable(
                name: "MateriaProfesor",
                columns: table => new
                {
                    MateriasId = table.Column<int>(type: "int", nullable: false),
                    ProfesoresBannerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaProfesor", x => new { x.MateriasId, x.ProfesoresBannerId });
                    table.ForeignKey(
                        name: "FK_MateriaProfesor_Materia_MateriasId",
                        column: x => x.MateriasId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaProfesor_Profesor_ProfesoresBannerId",
                        column: x => x.ProfesoresBannerId,
                        principalTable: "Profesor",
                        principalColumn: "BannerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MateriaProfesor_ProfesoresBannerId",
                table: "MateriaProfesor",
                column: "ProfesoresBannerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MateriaProfesor");

            migrationBuilder.AddColumn<int>(
                name: "MateriaId",
                table: "Profesor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_MateriaId",
                table: "Profesor",
                column: "MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Materia_MateriaId",
                table: "Profesor",
                column: "MateriaId",
                principalTable: "Materia",
                principalColumn: "Id");
        }
    }
}
