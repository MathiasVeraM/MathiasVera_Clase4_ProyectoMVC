﻿// <auto-generated />
using System;
using MathiasVera_Clase4_ProyectoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MathiasVera_Clase4_ProyectoMVC.Migrations
{
    [DbContext(typeof(MathiasVera_Clase4_ProyectoMVCContext))]
    partial class MathiasVera_Clase4_ProyectoMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MathiasVera_Clase4_ProyectoMVC.Models.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("MathiasVera_Clase4_ProyectoMVC.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCarrera")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("TieneBeca")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdCarrera");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("MathiasVera_Clase4_ProyectoMVC.Models.Estudiante", b =>
                {
                    b.HasOne("MathiasVera_Clase4_ProyectoMVC.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("IdCarrera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });
#pragma warning restore 612, 618
        }
    }
}
