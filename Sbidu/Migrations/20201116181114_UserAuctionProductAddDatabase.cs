using Microsoft.EntityFrameworkCore.Migrations;

namespace Sbidu.Migrations
{
    public partial class UserAuctionProductAddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAuctionProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bid = table.Column<int>(type: "int", nullable: true),
                    IsFavorit = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AuctionProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuctionProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAuctionProducts_AspNetUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAuctionProducts_AuctionProducts_AuctionProductId",
                        column: x => x.AuctionProductId,
                        principalTable: "AuctionProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAuctionProducts_AppUserId1",
                table: "UserAuctionProducts",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuctionProducts_AuctionProductId",
                table: "UserAuctionProducts",
                column: "AuctionProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAuctionProducts");
        }
    }
}
