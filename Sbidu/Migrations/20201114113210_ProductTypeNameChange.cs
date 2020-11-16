using Microsoft.EntityFrameworkCore.Migrations;

namespace Sbidu.Migrations
{
    public partial class ProductTypeNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartPrice",
                table: "AuctionProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<int>(
                name: "BuyNowPrice",
                table: "AuctionProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StartPrice",
                table: "AuctionProducts",
                type: "money",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyNowPrice",
                table: "AuctionProducts",
                type: "money",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
