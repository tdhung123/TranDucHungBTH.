﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace baithuchanhEXCEL.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20221102092105_Employee")]
    partial class Employee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("baithuchanhEXCEL.Models.Employee", b =>
                {
                    b.Property<string>("EmpID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpName")
                        .HasColumnType("TEXT");

                    b.HasKey("EmpID");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
