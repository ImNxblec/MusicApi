using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTarea.Migrations
{
    /// <inheritdoc />
    public partial class Vinculacio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
            migrationBuilder.InsertData(
table: "Movies",
columns: new[] { "Id", "Title", "Director", "Duracion" },
values: new object[] { 1, "Pacific Rim", "Guillermo del Toro", "132 minutos" });

            migrationBuilder.InsertData(
            table: "Movies",
            columns: new[] { "Id", "Title", "Director", "Duracion" },
            values: new object[] { 2, "Avatar", "James Cameron", "162 minutos" });

            migrationBuilder.InsertData(
            table: "Movies",
            columns: new[] { "Id", "Title", "Director", "Duracion" },
            values: new object[] { 3, "Avengers: Endgame", "Anthony y Joe Russo", "181 minutos" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
