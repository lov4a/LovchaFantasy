using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class CreateUserTeamGameWeekPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "userTeamGameWeekPlayers",
                columns: table => new
                {
                    UserTeamId = table.Column<int>(type: "integer", nullable: false),
                    GameId = table.Column<int>(type: "integer", nullable: false),
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    GameWeekId = table.Column<int>(type: "integer", nullable: false),
                    Captain = table.Column<bool>(type: "boolean", nullable: false),
                    ViceCaptain = table.Column<bool>(type: "boolean", nullable: false),
                    Bench = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTeamGameWeekPlayers", x => new { x.UserTeamId, x.GameId, x.PlayerId, x.GameWeekId });
                    table.ForeignKey(
                        name: "FK_userTeamGameWeekPlayers_gameWeekPlayers_PlayerId_GameWeekId",
                        columns: x => new { x.PlayerId, x.GameWeekId },
                        principalTable: "gameWeekPlayers",
                        principalColumns: new[] { "PlayerId", "GameWeekId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userTeamGameWeekPlayers_userTeam_UserTeamId_GameId",
                        columns: x => new { x.UserTeamId, x.GameId },
                        principalTable: "userTeam",
                        principalColumns: new[] { "Id", "GameId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userTeamGameWeekPlayers_PlayerId_GameWeekId",
                table: "userTeamGameWeekPlayers",
                columns: new[] { "PlayerId", "GameWeekId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userTeamGameWeekPlayers");
        }
    }
}
