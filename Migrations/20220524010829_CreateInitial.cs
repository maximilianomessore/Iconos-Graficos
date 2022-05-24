using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iconos_Graficos.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "continents",
                columns: table => new
                {
                    continentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_continents", x => x.continentID);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    cityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberResidents = table.Column<int>(type: "int", nullable: false),
                    totalArea = table.Column<int>(type: "int", nullable: false),
                    continentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.cityID);
                    table.ForeignKey(
                        name: "FK_cities_continents_continentID",
                        column: x => x.continentID,
                        principalTable: "continents",
                        principalColumn: "continentID");
                });

            migrationBuilder.CreateTable(
                name: "GraphicIcons",
                columns: table => new
                {
                    iconID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    height = table.Column<int>(type: "int", nullable: false),
                    history = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicIcons", x => x.iconID);
                    table.ForeignKey(
                        name: "FK_GraphicIcons_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cities_continentID",
                table: "cities",
                column: "continentID");

            migrationBuilder.CreateIndex(
                name: "IX_GraphicIcons_cityID",
                table: "GraphicIcons",
                column: "cityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GraphicIcons");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "continents");
        }
    }
}
