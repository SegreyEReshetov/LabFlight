using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Migr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Seats_SeatId",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_SeatId",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "Planes");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_PlaneId",
                table: "Seats",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Planes_PlaneId",
                table: "Seats",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Planes_PlaneId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_PlaneId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "Seats");

            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "Planes",
                type: "int",
                nullable: true);

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
    }
}
