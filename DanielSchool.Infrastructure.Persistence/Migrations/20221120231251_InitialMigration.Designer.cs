﻿// <auto-generated />
using System;
using DanielSchool.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DanielSchool.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221120231251_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DanielSchool.Core.Domain.Entities.Asignacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ttle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradoId");

                    b.ToTable("Asignacion");
                });

            modelBuilder.Entity("DanielSchool.Core.Domain.Entities.Calificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abril")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agosto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diciembre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frebrero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Julio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Junio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marzo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mayo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Noviembre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Octubre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Septiembre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Calificacion");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abril = "33,34,35,36",
                            Agosto = "1,2,3,4",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            Diciembre = "17,18,19,20",
                            Enero = "21,22,23,24",
                            Frebrero = "25,26,27,28",
                            Julio = "45,46,47,48",
                            Junio = "41,42,43,44",
                            Marzo = "29,30,31,32",
                            Mayo = "37,38,39,40",
                            Noviembre = "13,14,15,16",
                            Octubre = "9,10,11,12",
                            Septiembre = "5,6,7,8",
                            StudentId = "Estudiante_Usuario"
                        });
                });

            modelBuilder.Entity("DanielSchool.Core.Domain.Entities.DescCalificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCalification")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<int>("PuntosExtras")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DescCalificacion");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 2,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 3,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 4,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 5,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 6,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 7,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 8,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 9,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 10,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 11,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 12,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 13,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 14,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 15,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 16,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 17,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 18,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 19,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 20,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 21,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 22,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 23,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 24,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 25,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 26,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 27,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 28,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 29,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 30,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 31,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 32,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 33,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 34,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 35,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 36,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 37,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 38,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 39,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 40,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 41,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 42,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 43,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 44,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 45,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 46,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 47,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        },
                        new
                        {
                            Id = 48,
                            Comentarios = "N/A",
                            Created = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Admin",
                            IdCalification = 1,
                            Nota = 100,
                            PuntosExtras = 0
                        });
                });

            modelBuilder.Entity("DanielSchool.Core.Domain.Entities.Grado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Grado");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "4to",
                            Section = "A"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "4to",
                            Section = "B"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "5to",
                            Section = "A"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "5to",
                            Section = "B"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "6to",
                            Section = "A"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "6to",
                            Section = "B"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "7mo",
                            Section = "A"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "7mo",
                            Section = "B"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "8vo",
                            Section = "A"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "8vo",
                            Section = "B"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "9no",
                            Section = "A"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "9no",
                            Section = "B"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "10mo",
                            Section = "A"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "10mo",
                            Section = "B"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "11vo",
                            Section = "A"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "11vo",
                            Section = "B"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "12vo",
                            Section = "A"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "12vo",
                            Section = "B"
                        });
                });

            modelBuilder.Entity("DanielSchool.Core.Domain.Entities.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Publish")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Noticia");
                });

            modelBuilder.Entity("DanielSchool.Core.Domain.Entities.Asignacion", b =>
                {
                    b.HasOne("DanielSchool.Core.Domain.Entities.Grado", "NP_grado")
                        .WithMany("NP_asignations")
                        .HasForeignKey("GradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NP_grado");
                });

            modelBuilder.Entity("DanielSchool.Core.Domain.Entities.Grado", b =>
                {
                    b.Navigation("NP_asignations");
                });
#pragma warning restore 612, 618
        }
    }
}