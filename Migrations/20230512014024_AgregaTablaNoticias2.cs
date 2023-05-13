using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiciosClinicaUNMSM.Migrations
{
    /// <inheritdoc />
    public partial class AgregaTablaNoticias2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    id_noticia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url_noticia = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    img_noticia = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.id_noticia);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id_usuario",
                keyValue: 1,
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 11, 20, 40, 24, 468, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 5, 11, 20, 40, 24, 468, DateTimeKind.Local).AddTicks(2039) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticias");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id_usuario",
                keyValue: 1,
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 11, 20, 36, 58, 557, DateTimeKind.Local).AddTicks(3813), new DateTime(2023, 5, 11, 20, 36, 58, 557, DateTimeKind.Local).AddTicks(3793) });
        }
    }
}
