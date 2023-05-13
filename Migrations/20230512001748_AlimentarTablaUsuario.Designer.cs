﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiciosClinicaUNMSM.Datos;

#nullable disable

namespace ServiciosClinicaUNMSM.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230512001748_AlimentarTablaUsuario")]
    partial class AlimentarTablaUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServiciosClinicaUNMSM.Modelos.Usuario", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_usuario"));

                    b.Property<string>("apellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("apellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id_usuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            id_usuario = 1,
                            apellidoMaterno = "Soraluz",
                            apellidoPaterno = "Calle",
                            contrasenia = "12345",
                            correo = "jose.callesoraluz@unmsm.edu.pe",
                            estado = 1,
                            fechaActualizacion = new DateTime(2023, 5, 11, 19, 17, 48, 522, DateTimeKind.Local).AddTicks(9827),
                            fechaCreacion = new DateTime(2023, 5, 11, 19, 17, 48, 522, DateTimeKind.Local).AddTicks(9817),
                            imagen = "",
                            nombre = "Jose Bryan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
