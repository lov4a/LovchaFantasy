using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LovchaFantasy.Context.Migrations
{
    public partial class fixGame3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_images_imageId",
                table: "games");

            migrationBuilder.DropColumn(
                name: "end",
                table: "games");

            migrationBuilder.DropColumn(
                name: "start",
                table: "games");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "games",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "imageId",
                table: "games",
                newName: "ImageId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "games",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_games_imageId",
                table: "games",
                newName: "IX_games_ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_games_images_ImageId",
                table: "games",
                column: "ImageId",
                principalTable: "images",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_images_ImageId",
                table: "games");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "games",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "games",
                newName: "imageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "games",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_games_ImageId",
                table: "games",
                newName: "IX_games_imageId");

            migrationBuilder.AddColumn<DateOnly>(
                name: "end",
                table: "games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "start",
                table: "games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddForeignKey(
                name: "FK_games_images_imageId",
                table: "games",
                column: "imageId",
                principalTable: "images",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
