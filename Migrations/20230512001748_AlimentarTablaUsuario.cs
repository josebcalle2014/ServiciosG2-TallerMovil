﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiciosClinicaUNMSM.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id_usuario", "apellidoMaterno", "apellidoPaterno", "contrasenia", "correo", "estado", "fechaActualizacion", "fechaCreacion", "imagen", "nombre" },
                values: new object[] { 1, "Soraluz", "Calle", "12345", "jose.callesoraluz@unmsm.edu.pe", 1, new DateTime(2023, 5, 11, 19, 17, 48, 522, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 5, 11, 19, 17, 48, 522, DateTimeKind.Local).AddTicks(9817), "", "Jose Bryan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "id_usuario",
                keyValue: 1);
        }
    }
}
