using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Server.Data.Migrations
{
    public partial class ProductAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    EstimatedAge = table.Column<int>(nullable: true),
                    AnimalKind = table.Column<int>(nullable: false),
                    PictureUrl = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalKind", "DateOfBirth", "EstimatedAge", "Gender", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { 1, 0, null, 1, 1, "Max", "https://cdn.pixabay.com/photo/2017/06/24/09/13/dog-2437110__340.jpg" },
                    { 2, 1, new DateTime(2018, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Kitty", "https://cdn.pixabay.com/photo/2014/04/13/20/49/cat-323262__340.jpg" },
                    { 3, 0, null, 2, 0, "Lucy", "https://cdn.pixabay.com/photo/2018/03/18/18/06/australian-shepherd-3237735__340.jpg" },
                    { 4, 0, null, 3, 1, "Charlie", "https://cdn.pixabay.com/photo/2017/10/02/21/56/dog-2810484__340.jpg" },
                    { 5, 1, null, 1, 0, "Simba", "https://cdn.pixabay.com/photo/2017/11/09/21/41/cat-2934720__340.jpg" },
                    { 6, 1, null, 6, 1, "Sammy", "https://cdn.pixabay.com/photo/2017/03/14/14/49/cat-2143332__340.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
