using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace PruebaComponentesObdulio.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Componentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coste = table.Column<double>(type: "float", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calor = table.Column<int>(type: "int", nullable: false),
                    Cores = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Megas = table.Column<long>(type: "bigint", nullable: false),
                    TipoComponente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componentes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Componentes",
                columns: new[] { "Id", "Calor", "Cores", "Coste", "Descripcion", "Megas", "NumeroSerie", "TipoComponente" },
                values: new object[,]
                {
                    { 1, 10, 9, 134.0, "Procesador Intel i7", 0L, "789_XCS", 0 },
                    { 2, 12, 10, 138.0, "Procesador Intel i7", 0L, "789_XCD", 0 },
                    { 3, 22, 11, 138.0, "Procesador Intel i7", 0L, "789_XCT", 0 },
                    { 4, 10, 0, 100.0, "Banco de memoria SDRAM", 512L, "879FH", 1 },
                    { 5, 10, 0, 50.0, "Disco Duro Scan Disk", 500000L, "789_XX", 2 }
                });

            migrationBuilder.CreateTable(
            name: "Ordenadores",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                PrecioTotal = table.Column<double>(type: "float", nullable: false),
                Calortotal = table.Column<int>(type: "int", nullable: false),
                Corestotal = table.Column<int>(type: "int", nullable: false),
                Megastotal = table.Column<long>(type: "int", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Componentes", x => x.Id);
            });

            migrationBuilder.InsertData(
                table: "Ordenadores",
                columns: new[] { "Id", "PrecioTotal", "Calortotal", "Corestotal", "Megastotal" },
                values: new object[,]
                {
                    { 1, 10, 9, 134.0, "Procesador Intel i7", 0L, "789_XCS", 0 },
                    { 2, 12, 10, 138.0, "Procesador Intel i7", 0L, "789_XCD", 0 },
                    { 3, 22, 11, 138.0, "Procesador Intel i7", 0L, "789_XCT", 0 },
                    { 4, 10, 0, 100.0, "Banco de memoria SDRAM", 512L, "879FH", 1 },
                    { 5, 10, 0, 50.0, "Disco Duro Scan Disk", 500000L, "789_XX", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Componentes");
            migrationBuilder.DropTable(
                name: "Ordenadores");
        }
    }
}
