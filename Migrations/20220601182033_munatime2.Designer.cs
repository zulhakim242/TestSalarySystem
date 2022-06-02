﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestSalarySystem.Data;

#nullable disable

namespace TestSalarySystem.Migrations
{
    [DbContext(typeof(SalaryContext))]
    [Migration("20220601182033_munatime2")]
    partial class munatime2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestSalarySystem.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("TestSalarySystem.Models.Batch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Class", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TutorID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TutorID");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("TestSalarySystem.Models.Performance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.ToTable("Performance", (string)null);
                });

            modelBuilder.Entity("TestSalarySystem.Models.Salary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TutorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TutorID");

                    b.ToTable("Salary", (string)null);
                });

            modelBuilder.Entity("TestSalarySystem.Models.Status", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int?>("TutorID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("TutorID");

                    b.ToTable("Statuses", (string)null);
                });

            modelBuilder.Entity("TestSalarySystem.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BatchID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Package")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BatchID");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("TestSalarySystem.Models.Tutor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BatchID")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BatchID");

                    b.ToTable("Tutor", (string)null);
                });

            modelBuilder.Entity("TestSalarySystem.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Class", b =>
                {
                    b.HasOne("TestSalarySystem.Models.Tutor", "Tutor")
                        .WithMany("ClassList")
                        .HasForeignKey("TutorID");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Performance", b =>
                {
                    b.HasOne("TestSalarySystem.Models.Student", "Student")
                        .WithMany("performances")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Salary", b =>
                {
                    b.HasOne("TestSalarySystem.Models.Tutor", "Tutor")
                        .WithMany("SalaryList")
                        .HasForeignKey("TutorID");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Status", b =>
                {
                    b.HasOne("TestSalarySystem.Models.Student", "Student")
                        .WithOne("Status")
                        .HasForeignKey("TestSalarySystem.Models.Status", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestSalarySystem.Models.Tutor", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorID");

                    b.Navigation("Student");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Student", b =>
                {
                    b.HasOne("TestSalarySystem.Models.Batch", "Batch")
                        .WithMany("Students")
                        .HasForeignKey("BatchID");

                    b.Navigation("Batch");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Tutor", b =>
                {
                    b.HasOne("TestSalarySystem.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchID");

                    b.Navigation("Batch");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Batch", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Student", b =>
                {
                    b.Navigation("Status");

                    b.Navigation("performances");
                });

            modelBuilder.Entity("TestSalarySystem.Models.Tutor", b =>
                {
                    b.Navigation("ClassList");

                    b.Navigation("SalaryList");
                });
#pragma warning restore 612, 618
        }
    }
}