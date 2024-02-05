using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CombosRestaurantes.Migrations
{
    /// <inheritdoc />
    public partial class AgregoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCombo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConteniedoCombo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioCombo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ConteniedoCombo", "NombreCombo", "PrecioCombo" },
                values: new object[,]
                {
                    { 1, "8 presas de pollo + 1 papa frita grande + ensalada de col grande + 1 gaseosa 1L", "PROMO FESTIN FAMILIAR 1", "16.99" },
                    { 2, "3 presas de pollo + 6 alitas picantes + 2 papas fritas regulares + 1 gaseosa", "PARTE Y COMPARTE 3 PRESAS 6 ALITAS DE PROMO", "9.99" },
                    { 3, "7 presas de pollo", "MARTES LOCO 7 PRESAS", "8.99" },
                    { 4, "1 presa de pollo + 3 alitas picantes + arroz + menestras + ensalada + 1 gaseosa 355 ml", "MEGA COMBO 1 ALITAS", "4.99" },
                    { 5, "15 presas de pollo", "15 PRESAS KFC SOLAS PROMO", "20.99" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
