using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class Edit_Leagues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "leagues",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Main",
                table: "leagues",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_leagues_GameId",
                table: "leagues",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_leagues_games_GameId",
                table: "leagues",
                column: "GameId",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leagues_games_GameId",
                table: "leagues");

            migrationBuilder.DropIndex(
                name: "IX_leagues_GameId",
                table: "leagues");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "leagues");

            migrationBuilder.DropColumn(
                name: "Main",
                table: "leagues");
        }
    }
}
