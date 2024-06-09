﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solid.Data;

#nullable disable

namespace Solid.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240609125014_two")]
    partial class two
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Solid.Core.Models.CollegeC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("JobCId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobCId");

                    b.ToTable("CollegeList");
                });

            modelBuilder.Entity("Solid.Core.Models.EmployeeC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CollegeCId")
                        .HasColumnType("int");

                    b.Property<bool>("Experience")
                        .HasColumnType("bit");

                    b.Property<int?>("JobCId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollegeCId");

                    b.HasIndex("JobCId");

                    b.ToTable("EmployeeList");
                });

            modelBuilder.Entity("Solid.Core.Models.JobC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HoursInDay")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobList");
                });

            modelBuilder.Entity("Solid.Core.Models.CollegeC", b =>
                {
                    b.HasOne("Solid.Core.Models.JobC", null)
                        .WithMany("Colleges")
                        .HasForeignKey("JobCId");
                });

            modelBuilder.Entity("Solid.Core.Models.EmployeeC", b =>
                {
                    b.HasOne("Solid.Core.Models.CollegeC", null)
                        .WithMany("Employees")
                        .HasForeignKey("CollegeCId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Solid.Core.Models.JobC", null)
                        .WithMany("Employees")
                        .HasForeignKey("JobCId");
                });

            modelBuilder.Entity("Solid.Core.Models.CollegeC", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Solid.Core.Models.JobC", b =>
                {
                    b.Navigation("Colleges");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
