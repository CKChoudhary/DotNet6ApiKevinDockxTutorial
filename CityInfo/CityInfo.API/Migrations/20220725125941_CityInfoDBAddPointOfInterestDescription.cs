using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfo.API.Migrations
{
    public partial class CityInfoDBAddPointOfInterestDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PointsOfInterest",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The most visited urban park in the United States.");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A 102-story skyscraper located in Midtown Manhattan.");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans.");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The the finest example of railway architecture in Belgium.");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel.");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "The world's largest museum.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PointsOfInterest");
        }
    }
}
