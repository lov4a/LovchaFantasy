using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class CreateUserTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userLeagues_AspNetUsers_UserId",
                table: "userLeagues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userLeagues",
                table: "userLeagues");

            migrationBuilder.DropIndex(
                name: "IX_userLeagues_UserId",
                table: "userLeagues");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "userLeagues");

            migrationBuilder.AddColumn<int>(
                name: "UserTeamId",
                table: "userLeagues",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "userLeagues",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_userLeagues",
                table: "userLeagues",
                columns: new[] { "LeagueId", "UserTeamId", "GameId" });

            migrationBuilder.CreateTable(
                name: "userTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    GameId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTeam", x => new { x.Id, x.GameId });
                    table.ForeignKey(
                        name: "FK_userTeam_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userTeam_games_GameId",
                        column: x => x.GameId,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userLeagues_UserTeamId_GameId",
                table: "userLeagues",
                columns: new[] { "UserTeamId", "GameId" });

            migrationBuilder.CreateIndex(
                name: "IX_userTeam_GameId",
                table: "userTeam",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_userTeam_UserId",
                table: "userTeam",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_userLeagues_userTeam_UserTeamId_GameId",
                table: "userLeagues",
                columns: new[] { "UserTeamId", "GameId" },
                principalTable: "userTeam",
                principalColumns: new[] { "Id", "GameId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userLeagues_userTeam_UserTeamId_GameId",
                table: "userLeagues");

            migrationBuilder.DropTable(
                name: "userTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userLeagues",
                table: "userLeagues");

            migrationBuilder.DropIndex(
                name: "IX_userLeagues_UserTeamId_GameId",
                table: "userLeagues");

            migrationBuilder.DropColumn(
                name: "UserTeamId",
                table: "userLeagues");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "userLeagues");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "userLeagues",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userLeagues",
                table: "userLeagues",
                columns: new[] { "LeagueId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_userLeagues_UserId",
                table: "userLeagues",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_userLeagues_AspNetUsers_UserId",
                table: "userLeagues",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
