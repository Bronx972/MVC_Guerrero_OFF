using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Guerrero.Migrations
{
    public partial class _1er : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseidCourse",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentidStudent",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_CourseidCourse",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentidStudent",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "CourseidCourse",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "StudentidStudent",
                table: "Enrollments");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "Students",
                newName: "GradeID");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Students",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "idStudent",
                table: "Students",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GradeId",
                table: "Students",
                newName: "IX_Students_GradeID");

            migrationBuilder.RenameColumn(
                name: "idGrade",
                table: "Grades",
                newName: "GradeID");

            migrationBuilder.RenameColumn(
                name: "Student_id",
                table: "Enrollments",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "Course_id",
                table: "Enrollments",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "idEnrollment",
                table: "Enrollments",
                newName: "EnrollmentID");

            migrationBuilder.RenameColumn(
                name: "idCourse",
                table: "Courses",
                newName: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students",
                column: "GradeID",
                principalTable: "Grades",
                principalColumn: "GradeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments");

            migrationBuilder.RenameColumn(
                name: "GradeID",
                table: "Students",
                newName: "GradeId");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "Students",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Students",
                newName: "idStudent");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GradeID",
                table: "Students",
                newName: "IX_Students_GradeId");

            migrationBuilder.RenameColumn(
                name: "GradeID",
                table: "Grades",
                newName: "idGrade");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Enrollments",
                newName: "Student_id");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Enrollments",
                newName: "Course_id");

            migrationBuilder.RenameColumn(
                name: "EnrollmentID",
                table: "Enrollments",
                newName: "idEnrollment");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Courses",
                newName: "idCourse");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Grades",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CourseidCourse",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentidStudent",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseidCourse",
                table: "Enrollments",
                column: "CourseidCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentidStudent",
                table: "Enrollments",
                column: "StudentidStudent");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "idGrade",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
