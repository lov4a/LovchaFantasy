using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class AddNewRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FwdCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GkCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MidCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartUpDefCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartUpFwdCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartUpGkCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartUpMidCount",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "Completed",
                table: "gameWeeks",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefCount",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "FwdCount",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "GkCount",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "MidCount",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "StartUpDefCount",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "StartUpFwdCount",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "StartUpGkCount",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "StartUpMidCount",
                table: "rules");

            migrationBuilder.AlterColumn<bool>(
                name: "Completed",
                table: "gameWeeks",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);
        }
    }
}
