using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ornek1.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTableHasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Laptop" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Ryzen 9 6900HX 16GB RAM 1TB SSD 8GB RTX3080 17.3 FHD 360Hz", 111m, "Asus ROG Strix G17 G713RS-KH010 ", 15000m },
                    { 2, 1, "32GB DDR5 2TB SSD RTX3070Ti 8GB 17,3 Windows 11 Home Gaming Notebook", 111m, "MSI RAIDER GE77HX 12UGS-039TR i7 12800HX", 78087m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
