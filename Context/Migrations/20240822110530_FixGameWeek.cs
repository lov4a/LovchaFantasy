using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class FixGameWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gameWeeks_games_GameID",
                table: "gameWeeks");

            migrationBuilder.RenameColumn(
                name: "GameID",
                table: "gameWeeks",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_gameWeeks_GameID",
                table: "gameWeeks",
                newName: "IX_gameWeeks_GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_gameWeeks_games_GameId",
                table: "gameWeeks",
                column: "GameId",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gameWeeks_games_GameId",
                table: "gameWeeks");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "gameWeeks",
                newName: "GameID");

            migrationBuilder.RenameIndex(
                name: "IX_gameWeeks_GameId",
                table: "gameWeeks",
                newName: "IX_gameWeeks_GameID");

            migrationBuilder.AddForeignKey(
                name: "FK_gameWeeks_games_GameID",
                table: "gameWeeks",
                column: "GameID",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
