﻿// <auto-generated />
using System;
using EKZ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ekz_Apteka.Migrations
{
    [DbContext(typeof(EkzDbContext))]
    [Migration("20211221125930_Update Medicine")]
    partial class UpdateMedicine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ekz_Apteka.Models.Medicine", b =>
                {
                    b.Property<long>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("MedicinePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("SellTime")
                        .HasColumnType("datetime2");

                    b.HasKey("MedicineId");

                    b.ToTable("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}