﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TranDucHungBTH2.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20221009160936_Employee")]
    partial class Employee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("TranDucHungBTH2.Models.Customer", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaKH")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SĐT")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("TranDucHungBTH2.Models.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("phongban")
                        .HasColumnType("TEXT");

                    b.Property<string>("tên")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TranDucHungBTH2.Models.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Personname")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("namsinh")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("TranDucHungBTH2.Models.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Studentname")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
