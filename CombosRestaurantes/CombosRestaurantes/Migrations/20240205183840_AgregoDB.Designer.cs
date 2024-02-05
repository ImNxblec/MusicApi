﻿// <auto-generated />
using CombosRestaurantes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CombosRestaurantes.Migrations
{
    [DbContext(typeof(ComboDbContext))]
    [Migration("20240205183840_AgregoDB")]
    partial class AgregoDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CombosRestaurantes.Models.Combo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConteniedoCombo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCombo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecioCombo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConteniedoCombo = "8 presas de pollo + 1 papa frita grande + ensalada de col grande + 1 gaseosa 1L",
                            NombreCombo = "PROMO FESTIN FAMILIAR 1",
                            PrecioCombo = "16.99"
                        },
                        new
                        {
                            Id = 2,
                            ConteniedoCombo = "3 presas de pollo + 6 alitas picantes + 2 papas fritas regulares + 1 gaseosa",
                            NombreCombo = "PARTE Y COMPARTE 3 PRESAS 6 ALITAS DE PROMO",
                            PrecioCombo = "9.99"
                        },
                        new
                        {
                            Id = 3,
                            ConteniedoCombo = "7 presas de pollo",
                            NombreCombo = "MARTES LOCO 7 PRESAS",
                            PrecioCombo = "8.99"
                        },
                        new
                        {
                            Id = 4,
                            ConteniedoCombo = "1 presa de pollo + 3 alitas picantes + arroz + menestras + ensalada + 1 gaseosa 355 ml",
                            NombreCombo = "MEGA COMBO 1 ALITAS",
                            PrecioCombo = "4.99"
                        },
                        new
                        {
                            Id = 5,
                            ConteniedoCombo = "15 presas de pollo",
                            NombreCombo = "15 PRESAS KFC SOLAS PROMO",
                            PrecioCombo = "20.99"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}