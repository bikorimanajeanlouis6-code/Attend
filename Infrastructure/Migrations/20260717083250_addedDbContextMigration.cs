using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedDbContextMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceStudent_Attendance_AttendancesId",
                table: "AttendanceStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Classses_EducationLevel_EducationLevelId",
                table: "Classses");

            migrationBuilder.DropForeignKey(
                name: "FK_Classses_Faculty_FacultyId",
                table: "Classses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationLevel",
                table: "EducationLevel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.RenameTable(
                name: "Faculty",
                newName: "Faculties");

            migrationBuilder.RenameTable(
                name: "EducationLevel",
                newName: "EducationLevels");

            migrationBuilder.RenameTable(
                name: "Attendance",
                newName: "Attendances");

            migrationBuilder.AddColumn<int>(
                name: "ClassStudentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassStudentId",
                table: "Attendances",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationLevels",
                table: "EducationLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ClassStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    AttendanceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GetDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAttendances_Attendances_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAttendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassStudentId",
                table: "Students",
                column: "ClassStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ClassStudentId",
                table: "Attendances",
                column: "ClassStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudents_StudentId",
                table: "ClassStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendances_AttendanceId",
                table: "StudentAttendances",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendances_StudentId",
                table: "StudentAttendances",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_ClassStudents_ClassStudentId",
                table: "Attendances",
                column: "ClassStudentId",
                principalTable: "ClassStudents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceStudent_Attendances_AttendancesId",
                table: "AttendanceStudent",
                column: "AttendancesId",
                principalTable: "Attendances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classses_EducationLevels_EducationLevelId",
                table: "Classses",
                column: "EducationLevelId",
                principalTable: "EducationLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classses_Faculties_FacultyId",
                table: "Classses",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ClassStudents_ClassStudentId",
                table: "Students",
                column: "ClassStudentId",
                principalTable: "ClassStudents",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_ClassStudents_ClassStudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceStudent_Attendances_AttendancesId",
                table: "AttendanceStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Classses_EducationLevels_EducationLevelId",
                table: "Classses");

            migrationBuilder.DropForeignKey(
                name: "FK_Classses_Faculties_FacultyId",
                table: "Classses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ClassStudents_ClassStudentId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "ClassStudents");

            migrationBuilder.DropTable(
                name: "StudentAttendances");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassStudentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationLevels",
                table: "EducationLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_ClassStudentId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "ClassStudentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassStudentId",
                table: "Attendances");

            migrationBuilder.RenameTable(
                name: "Faculties",
                newName: "Faculty");

            migrationBuilder.RenameTable(
                name: "EducationLevels",
                newName: "EducationLevel");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "Attendance");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationLevel",
                table: "EducationLevel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceStudent_Attendance_AttendancesId",
                table: "AttendanceStudent",
                column: "AttendancesId",
                principalTable: "Attendance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classses_EducationLevel_EducationLevelId",
                table: "Classses",
                column: "EducationLevelId",
                principalTable: "EducationLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classses_Faculty_FacultyId",
                table: "Classses",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
