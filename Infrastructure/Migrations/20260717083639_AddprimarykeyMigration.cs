using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddprimarykeyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classses_Students_StudentId",
                table: "Classses");

            migrationBuilder.DropIndex(
                name: "IX_Classses_StudentId",
                table: "Classses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Classses");

            migrationBuilder.CreateTable(
                name: "ClasssStudent",
                columns: table => new
                {
                    ClasssesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasssStudent", x => new { x.ClasssesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_ClasssStudent_Classses_ClasssesId",
                        column: x => x.ClasssesId,
                        principalTable: "Classses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClasssStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClasssStudent_StudentsId",
                table: "ClasssStudent",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClasssStudent");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Classses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classses_StudentId",
                table: "Classses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classses_Students_StudentId",
                table: "Classses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
