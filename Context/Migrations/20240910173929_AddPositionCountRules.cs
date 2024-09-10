using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class AddPositionCountRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "positionCountRules",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "integer", nullable: false),
                    PositionId = table.Column<int>(type: "integer", nullable: false),
                    MaxCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positionCountRules", x => new { x.GameId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_positionCountRules_games_GameId",
                        column: x => x.GameId,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_positionCountRules_positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_positionCountRules_PositionId",
                table: "positionCountRules",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "positionCountRules");
        }
    }
}
