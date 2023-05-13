using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiciosClinicaUNMSM.Migrations
{
    /// <inheritdoc />
    public partial class AgregaTablaNoticias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id_usuario",
                keyValue: 1,
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 11, 20, 36, 58, 557, DateTimeKind.Local).AddTicks(3813), new DateTime(2023, 5, 11, 20, 36, 58, 557, DateTimeKind.Local).AddTicks(3793) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id_usuario",
                keyValue: 1,
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 11, 19, 17, 48, 522, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 5, 11, 19, 17, 48, 522, DateTimeKind.Local).AddTicks(9817) });
        }
    }
}
