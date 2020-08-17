using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Server.Data.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    VatPercentage = table.Column<int>(nullable: false),
                    ProductImageUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductImageUrl", "VatPercentage" },
                values: new object[] { 1, "Dogfood", 10.99m, "https://upload.wikimedia.org/wikipedia/commons/4/4f/Hundefutter.jpg", 21 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductImageUrl", "VatPercentage" },
                values: new object[] { 2, "Catfood", 8.99m, "https://upload.wikimedia.org/wikipedia/commons/1/16/Whiskas_cat%27s_petfood_with_chicken_dry.jpg", 21 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductImageUrl", "VatPercentage" },
                values: new object[] { 3, "Cat litter 50 liter", 15.12m, "https://www.publicdomainpictures.net/pictures/30000/velka/cat-litter.jpg", 21 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
