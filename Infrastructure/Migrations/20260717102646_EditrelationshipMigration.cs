using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditrelationshipMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceStudent");

            migrationBuilder.DropTable(
                name: "ClasssStudent");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendances_AttendanceId",
                table: "StudentAttendances",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAttendances_Attendances_AttendanceId",
                table: "StudentAttendances",
                column: "AttendanceId",
                principalTable: "Attendances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttendances_Attendances_AttendanceId",
                table: "StudentAttendances");

            migrationBuilder.DropIndex(
                name: "IX_StudentAttendances_AttendanceId",
                table: "StudentAttendances");

            migrationBuilder.CreateTable(
                name: "AttendanceStudent",
                columns: table => new
                {
                    AttendancesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceStudent", x => new { x.AttendancesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_AttendanceStudent_Attendances_AttendancesId",
                        column: x => x.AttendancesId,
                        principalTable: "Attendances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendanceStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AttendanceStudent_StudentsId",
                table: "AttendanceStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClasssStudent_StudentsId",
                table: "ClasssStudent",
                column: "StudentsId");
        }
    }
}
