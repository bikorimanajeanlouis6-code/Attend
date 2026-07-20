using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removingdoubleentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttendances_Attendances_AttendanceId",
                table: "StudentAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ClassStudents_ClassStudentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassStudentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentAttendances_AttendanceId",
                table: "StudentAttendances");

            migrationBuilder.DropColumn(
                name: "ClassStudentId",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassStudentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassStudentId",
                table: "Students",
                column: "ClassStudentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ClassStudents_ClassStudentId",
                table: "Students",
                column: "ClassStudentId",
                principalTable: "ClassStudents",
                principalColumn: "Id");
        }
    }
}
