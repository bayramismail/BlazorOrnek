using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ornek1.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://m.media-amazon.com/images/I/71lixkqPdxL._AC_SL1500_.jpg", 1 },
                    { 2, "https://m.media-amazon.com/images/I/71II0q7ZakL._AC_SL1500_.jpg", 1 },
                    { 3, "https://m.media-amazon.com/images/I/61SC2adpsuL._AC_SL1500_.jpg", 1 },
                    { 4, "https://m.media-amazon.com/images/I/51knE-Dz7+L._AC_SL1500_.jpg", 1 },
                    { 5, "https://m.media-amazon.com/images/I/61uxDTnehrL._AC_SL1500_.jpg", 2 },
                    { 6, "https://m.media-amazon.com/images/I/51mYZdJe4SL._AC_SL1000_.jpg", 2 },
                    { 7, "https://m.media-amazon.com/images/I/61aEOx3FA1L._AC_SL1500_.jpg", 2 },
                    { 8, "https://m.media-amazon.com/images/I/51fSPNd7+7L._AC_SL1500_.jpg", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");
        }
    }
}
