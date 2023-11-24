using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Guerrero.Migrations
{
    public partial class Migración3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseidCourse",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentidStudent",
                table: "Enrollments");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Grades",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "StudentidStudent",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseidCourse",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseidCourse",
                table: "Enrollments",
                column: "CourseidCourse",
                principalTable: "Courses",
                principalColumn: "idCourse");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentidStudent",
                table: "Enrollments",
                column: "StudentidStudent",
                principalTable: "Students",
                principalColumn: "idStudent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseidCourse",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentidStudent",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Grades");

            migrationBuilder.AlterColumn<int>(
                name: "StudentidStudent",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseidCourse",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseidCourse",
                table: "Enrollments",
                column: "CourseidCourse",
                principalTable: "Courses",
                principalColumn: "idCourse",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentidStudent",
                table: "Enrollments",
                column: "StudentidStudent",
                principalTable: "Students",
                principalColumn: "idStudent",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
