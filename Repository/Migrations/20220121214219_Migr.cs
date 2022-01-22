using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Num",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "Planes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Arrival",
                table: "Flights",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Planes_SeatId",
                table: "Planes",
                column: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Seats_SeatId",
                table: "Planes",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Seats_SeatId",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_SeatId",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "Num",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "Arrival",
                table: "Flights");
        }
    }
}
