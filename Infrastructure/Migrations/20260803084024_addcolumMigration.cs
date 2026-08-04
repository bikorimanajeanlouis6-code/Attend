using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addcolumMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_ClassStudents_ClassStudentId",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_ClassStudentId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "ClassStudentId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "StudentAttendances",
                newName: "DateAdded");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Attendances",
                newName: "ClasssId");

            migrationBuilder.AddColumn<string>(
                name: "UserAdded",
                table: "StudentAttendances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Faculties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserAdded",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "EducationLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "EducationLevels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserAdded",
                table: "EducationLevels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClasssId",
                table: "ClassStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "ClassStudents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ClassStudents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserAdded",
                table: "ClassStudents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudents_ClasssId",
                table: "ClassStudents",
                column: "ClasssId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ClasssId",
                table: "Attendances",
                column: "ClasssId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Classses_ClasssId",
                table: "Attendances",
                column: "ClasssId",
                principalTable: "Classses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudents_Classses_ClasssId",
                table: "ClassStudents",
                column: "ClasssId",
                principalTable: "Classses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Classses_ClasssId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudents_Classses_ClasssId",
                table: "ClassStudents");

            migrationBuilder.DropIndex(
                name: "IX_ClassStudents_ClasssId",
                table: "ClassStudents");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_ClasssId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "UserAdded",
                table: "StudentAttendances");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "UserAdded",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "UserAdded",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "ClasssId",
                table: "ClassStudents");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "ClassStudents");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ClassStudents");

            migrationBuilder.DropColumn(
                name: "UserAdded",
                table: "ClassStudents");

            migrationBuilder.RenameColumn(
                name: "DateAdded",
                table: "StudentAttendances",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "ClasssId",
                table: "Attendances",
                newName: "ClassId");

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Attendances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassStudentId",
                table: "Attendances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ClassStudentId",
                table: "Attendances",
                column: "ClassStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_ClassStudents_ClassStudentId",
                table: "Attendances",
                column: "ClassStudentId",
                principalTable: "ClassStudents",
                principalColumn: "Id");
        }
    }
}
