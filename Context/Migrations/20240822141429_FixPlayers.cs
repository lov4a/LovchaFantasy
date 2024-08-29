using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class FixPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_clubs_ClubId",
                table: "players");

            migrationBuilder.DropForeignKey(
                name: "FK_players_positions_PositionId",
                table: "players");

            migrationBuilder.AddForeignKey(
                name: "FK_players_clubs_ClubId",
                table: "players",
                column: "ClubId",
                principalTable: "clubs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_players_positions_PositionId",
                table: "players",
                column: "PositionId",
                principalTable: "positions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_clubs_ClubId",
                table: "players");

            migrationBuilder.DropForeignKey(
                name: "FK_players_positions_PositionId",
                table: "players");

            migrationBuilder.AddForeignKey(
                name: "FK_players_clubs_ClubId",
                table: "players",
                column: "ClubId",
                principalTable: "clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_players_positions_PositionId",
                table: "players",
                column: "PositionId",
                principalTable: "positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
