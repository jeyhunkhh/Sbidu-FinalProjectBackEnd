﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Sbidu.Migrations
{
    public partial class AuctionProductAddSold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Sold",
                table: "AuctionProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sold",
                table: "AuctionProducts");
        }
    }
}
