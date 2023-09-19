using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaComponentesObdulio.Migrations
{
    /// <inheritdoc />
    public partial class Nuevo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Componentes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Calor", "Cores", "NumeroSerie" },
                values: new object[] { 12, 10, "789_XCD" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Componentes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Calor", "Cores", "NumeroSerie" },
                values: new object[] { 22, 11, "789_XCT" });
        }
    }
}
