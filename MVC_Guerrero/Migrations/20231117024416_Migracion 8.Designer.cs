﻿// <auto-generated />
using System;
using MVC_Guerrero.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Guerrero.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20231117024416_Migracion 8")]
    partial class Migracion8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC_Guerrero.Models.Course", b =>
                {
                    b.Property<int>("idCourse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCourse"), 1L, 1);

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCourse");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MVC_Guerrero.Models.Enrollment", b =>
                {
                    b.Property<int>("idEnrollment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEnrollment"), 1L, 1);

                    b.Property<int>("Course_id")
                        .HasColumnType("int");

                    b.Property<int?>("CourseidCourse")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Student_id")
                        .HasColumnType("int");

                    b.Property<int?>("StudentidStudent")
                        .HasColumnType("int");

                    b.HasKey("idEnrollment");

                    b.HasIndex("CourseidCourse");

                    b.HasIndex("StudentidStudent");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("MVC_Guerrero.Models.Grade", b =>
                {
                    b.Property<int>("idGrade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idGrade"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idGrade");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("MVC_Guerrero.Models.Student", b =>
                {
                    b.Property<int>("idStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idStudent"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idStudent");

                    b.HasIndex("GradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MVC_Guerrero.Models.Enrollment", b =>
                {
                    b.HasOne("MVC_Guerrero.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseidCourse");

                    b.HasOne("MVC_Guerrero.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentidStudent");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MVC_Guerrero.Models.Student", b =>
                {
                    b.HasOne("MVC_Guerrero.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });
#pragma warning restore 612, 618
        }
    }
}
