using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class AddRules2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rules",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "integer", nullable: false),
                    TeamCount = table.Column<int>(type: "integer", nullable: false),
                    OneClubPlayersCount = table.Column<int>(type: "integer", nullable: false),
                    GwTransfers = table.Column<int>(type: "integer", nullable: false),
                    MaxTransfers = table.Column<int>(type: "integer", nullable: false),
                    BenchCount = table.Column<int>(type: "integer", nullable: false),
                    TimePoints = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rules", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_rules_games_GameId",
                        column: x => x.GameId,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rules");
        }
    }
}
