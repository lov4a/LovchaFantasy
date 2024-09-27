using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class fixGame4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "End",
                table: "games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "Start",
                table: "games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "games");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "games");
        }
    }
}
