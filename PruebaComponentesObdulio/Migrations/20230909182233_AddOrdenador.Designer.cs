﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaComponentesObdulio.Data;

#nullable disable

namespace PruebaComponentesObdulio.Migrations
{
    [DbContext(typeof(TiendaOrdenadoresContext))]
    [Migration("20230909182233_AddOrdenador")]
    partial class AddOrdenador
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaComponentesObdulio.Models.Componente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calor")
                        .HasColumnType("int");

                    b.Property<int>("Cores")
                        .HasColumnType("int");

                    b.Property<double>("Coste")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Megas")
                        .HasColumnType("bigint");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoComponente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Componentes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calor = 10,
                            Cores = 9,
                            Coste = 134.0,
                            Descripcion = "Procesador Intel i7",
                            Megas = 0L,
                            NumeroSerie = "789_XCS",
                            TipoComponente = 0
                        },
                        new
                        {
                            Id = 2,
                            Calor = 12,
                            Cores = 10,
                            Coste = 138.0,
                            Descripcion = "Procesador Intel i7",
                            Megas = 0L,
                            NumeroSerie = "789_XCD",
                            TipoComponente = 0
                        },
                        new
                        {
                            Id = 3,
                            Calor = 12,
                            Cores = 10,
                            Coste = 138.0,
                            Descripcion = "Procesador Intel i7",
                            Megas = 0L,
                            NumeroSerie = "789_XCD",
                            TipoComponente = 0
                        },
                        new
                        {
                            Id = 4,
                            Calor = 10,
                            Cores = 0,
                            Coste = 100.0,
                            Descripcion = "Banco de memoria SDRAM",
                            Megas = 512L,
                            NumeroSerie = "879FH",
                            TipoComponente = 1
                        },
                        new
                        {
                            Id = 5,
                            Calor = 10,
                            Cores = 0,
                            Coste = 50.0,
                            Descripcion = "Disco Duro Scan Disk",
                            Megas = 500000L,
                            NumeroSerie = "789_XX",
                            TipoComponente = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
