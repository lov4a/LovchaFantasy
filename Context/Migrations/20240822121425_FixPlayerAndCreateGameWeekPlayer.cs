using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class FixPlayerAndCreateGameWeekPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "players",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "gameWeekPlayers",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    GameWeekId = table.Column<int>(type: "integer", nullable: false),
                    PositionId = table.Column<int>(type: "integer", nullable: false),
                    ClubId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameWeekPlayers", x => new { x.PlayerId, x.GameWeekId });
                    table.ForeignKey(
                        name: "FK_gameWeekPlayers_clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_gameWeekPlayers_gameWeeks_GameWeekId",
                        column: x => x.GameWeekId,
                        principalTable: "gameWeeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gameWeekPlayers_players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gameWeekPlayers_positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_players_ImageId",
                table: "players",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_gameWeekPlayers_ClubId",
                table: "gameWeekPlayers",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_gameWeekPlayers_GameWeekId",
                table: "gameWeekPlayers",
                column: "GameWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_gameWeekPlayers_PositionId",
                table: "gameWeekPlayers",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_players_images_ImageId",
                table: "players",
                column: "ImageId",
                principalTable: "images",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_images_ImageId",
                table: "players");

            migrationBuilder.DropTable(
                name: "gameWeekPlayers");

            migrationBuilder.DropIndex(
                name: "IX_players_ImageId",
                table: "players");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "players");
        }
    }
}
