using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class EditRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxUserTeams",
                table: "rules",
                type: "integer",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<double>(
                name: "StartBalance",
                table: "rules",
                type: "double precision",
                nullable: false,
                defaultValue: 100.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxUserTeams",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "StartBalance",
                table: "rules");
        }
    }
}
