﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231117091304_EstudiosAcademicos")]
    partial class EstudiosAcademicos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.Candidato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("DataAccess.Entities.EstudiosAcademicos", b =>
                {
                    b.Property<int>("EstudiosAcademicosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstudiosAcademicosId"));

                    b.Property<int>("CandidatoID")
                        .HasColumnType("int");

                    b.Property<string>("EntidadEmisora")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("TituloObtenido")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("EstudiosAcademicosId");

                    b.ToTable("EstudiosAcademicos");
                });

            modelBuilder.Entity("DataAccess.Entities.ExperienciaLaboral", b =>
                {
                    b.Property<int>("ExperienciaLaboralID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExperienciaLaboralID"));

                    b.Property<int>("CandidatoID")
                        .HasColumnType("int");

                    b.Property<string>("EntidadTrabajo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ExperienciaLaboralID");

                    b.ToTable("ExperienciaLaboral");
                });

            modelBuilder.Entity("DataAccess.Entities.SolicitudesAceptadas", b =>
                {
                    b.Property<int>("SolicitudAceptadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SolicitudAceptadaId"));

                    b.Property<DateTime>("FechaAceptacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("SolicitudID")
                        .HasColumnType("int");

                    b.HasKey("SolicitudAceptadaId");

                    b.ToTable("SolicitudesAceptadas");
                });

            modelBuilder.Entity("DataAccess.Entities.TiposEspecialidad", b =>
                {
                    b.Property<int>("TipoEspecialidadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoEspecialidadID"));

                    b.Property<string>("NombreTipoEspecialidad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TipoEspecialidadID");

                    b.ToTable("TiposEspecialidad");
                });

            modelBuilder.Entity("DataAccess.Entities.Universidad", b =>
                {
                    b.Property<int>("universidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("universidadId"));

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("universidadNombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("universidadId");

                    b.ToTable("Universidad");
                });
#pragma warning restore 612, 618
        }
    }
}