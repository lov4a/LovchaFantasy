using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class AddImagesToGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "imageId",
                table: "games",
                type: "integer",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_games_imageId",
                table: "games",
                column: "imageId");

            migrationBuilder.AddForeignKey(
                name: "FK_games_images_imageId",
                table: "games",
                column: "imageId",
                principalTable: "images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_images_imageId",
                table: "games");

            migrationBuilder.DropIndex(
                name: "IX_games_imageId",
                table: "games");

            migrationBuilder.DropColumn(
                name: "imageId",
                table: "games");
        }
    }
}
