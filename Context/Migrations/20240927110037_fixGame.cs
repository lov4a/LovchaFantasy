using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class fixGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_images_imageId",
                table: "games");

            migrationBuilder.AddForeignKey(
                name: "FK_games_images_imageId",
                table: "games",
                column: "imageId",
                principalTable: "images",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_images_imageId",
                table: "games");

            migrationBuilder.AddForeignKey(
                name: "FK_games_images_imageId",
                table: "games",
                column: "imageId",
                principalTable: "images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
