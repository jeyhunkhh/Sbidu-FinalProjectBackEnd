using Microsoft.EntityFrameworkCore.Migrations;

namespace Sbidu.Migrations
{
    public partial class UserAuctionDeleteAndNewAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAuctionProducts_AspNetUsers_AppUserId1",
                table: "UserAuctionProducts");

            migrationBuilder.DropIndex(
                name: "IX_UserAuctionProducts_AppUserId1",
                table: "UserAuctionProducts");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "UserAuctionProducts");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "UserAuctionProducts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuctionProducts_AppUserId",
                table: "UserAuctionProducts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAuctionProducts_AspNetUsers_AppUserId",
                table: "UserAuctionProducts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAuctionProducts_AspNetUsers_AppUserId",
                table: "UserAuctionProducts");

            migrationBuilder.DropIndex(
                name: "IX_UserAuctionProducts_AppUserId",
                table: "UserAuctionProducts");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "UserAuctionProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "UserAuctionProducts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAuctionProducts_AppUserId1",
                table: "UserAuctionProducts",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAuctionProducts_AspNetUsers_AppUserId1",
                table: "UserAuctionProducts",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
