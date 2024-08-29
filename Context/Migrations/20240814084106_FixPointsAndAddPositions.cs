using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class FixPointsAndAddPositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_points",
                table: "points");

            migrationBuilder.DropColumn(
                name: "TimePoints",
                table: "rules");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "points",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_points",
                table: "points",
                columns: new[] { "GameId", "ActionnId", "PositionId" });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_points_PositionId",
                table: "points",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_points_positions_PositionId",
                table: "points",
                column: "PositionId",
                principalTable: "positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_points_positions_PositionId",
                table: "points");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_points",
                table: "points");

            migrationBuilder.DropIndex(
                name: "IX_points_PositionId",
                table: "points");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "points");

            migrationBuilder.AddColumn<bool>(
                name: "TimePoints",
                table: "rules",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_points",
                table: "points",
                columns: new[] { "GameId", "ActionnId" });
        }
    }
}
