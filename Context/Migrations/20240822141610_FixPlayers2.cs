using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class FixPlayers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_clubs_ClubId",
                table: "players");

            migrationBuilder.DropForeignKey(
                name: "FK_players_positions_PositionId",
                table: "players");

            migrationBuilder.DropIndex(
                name: "IX_players_ClubId",
                table: "players");

            migrationBuilder.DropIndex(
                name: "IX_players_PositionId",
                table: "players");

            migrationBuilder.DropColumn(
                name: "ClubId",
                table: "players");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubId",
                table: "players",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "players",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_players_ClubId",
                table: "players",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_players_PositionId",
                table: "players",
                column: "PositionId");

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
    }
}
