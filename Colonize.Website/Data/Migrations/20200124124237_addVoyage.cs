using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class addVoyage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage");

            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage");

            migrationBuilder.DropColumn(
                name: "Destription",
                table: "Ship");

            migrationBuilder.DropColumn(
                name: "PassagerCapacity",
                table: "Ship");

            migrationBuilder.DropColumn(
                name: "Destription",
                table: "Destination");

            migrationBuilder.RenameColumn(
                name: "Departureat",
                table: "Voyage",
                newName: "DepartureAt");

            migrationBuilder.AlterColumn<int>(
                name: "ShipId",
                table: "Voyage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Voyage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ship",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PassengerCapacity",
                table: "Ship",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Destination",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor", "https://via.placeholder.com/480x360.png?text=Moon", "Moon" },
                    { 2, "Lorem ipsum dolor", "https://via.placeholder.com/480x360.png?text=Mars", "Mars" }
                });

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "PassengerCapacity" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor", "https://via.placeholder.com/480x360.png?text=Moonshot", "Moonshot", 200 },
                    { 2, "Lorem ipsum dolor", "https://via.placeholder.com/480x360.png?text=Mars+Explorer", "Mars Explorer", 2800 }
                });

            migrationBuilder.InsertData(
                table: "Voyage",
                columns: new[] { "Id", "ArrivalAt", "DepartureAt", "DestinationId", "ShipId" },
                values: new object[] { 1, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Voyage",
                columns: new[] { "Id", "ArrivalAt", "DepartureAt", "DestinationId", "ShipId" },
                values: new object[] { 2, new DateTime(2029, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage",
                column: "ShipId",
                principalTable: "Ship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage");

            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage");

            migrationBuilder.DeleteData(
                table: "Voyage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voyage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ship");

            migrationBuilder.DropColumn(
                name: "PassengerCapacity",
                table: "Ship");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Destination");

            migrationBuilder.RenameColumn(
                name: "DepartureAt",
                table: "Voyage",
                newName: "Departureat");

            migrationBuilder.AlterColumn<int>(
                name: "ShipId",
                table: "Voyage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Voyage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Destription",
                table: "Ship",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PassagerCapacity",
                table: "Ship",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Destription",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage",
                column: "ShipId",
                principalTable: "Ship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
