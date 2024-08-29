using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class CreateUserTeamBalanceAndGameWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gameWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    GameID = table.Column<int>(type: "integer", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameWeeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gameWeeks_games_GameID",
                        column: x => x.GameID,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userTeamBalances",
                columns: table => new
                {
                    UserTeamId = table.Column<int>(type: "integer", nullable: false),
                    GameId = table.Column<int>(type: "integer", nullable: false),
                    GameWeekId = table.Column<int>(type: "integer", nullable: false),
                    Balance = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTeamBalances", x => new { x.UserTeamId, x.GameId, x.GameWeekId });
                    table.ForeignKey(
                        name: "FK_userTeamBalances_gameWeeks_GameWeekId",
                        column: x => x.GameWeekId,
                        principalTable: "gameWeeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userTeamBalances_userTeam_UserTeamId_GameId",
                        columns: x => new { x.UserTeamId, x.GameId },
                        principalTable: "userTeam",
                        principalColumns: new[] { "Id", "GameId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_gameWeeks_GameID",
                table: "gameWeeks",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_userTeamBalances_GameWeekId",
                table: "userTeamBalances",
                column: "GameWeekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userTeamBalances");

            migrationBuilder.DropTable(
                name: "gameWeeks");
        }
    }
}
