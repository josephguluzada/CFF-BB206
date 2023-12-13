﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class IsFeaturedIsNewIsBestsellerColumnsAddedIntoBooksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBestseller",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBestseller",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Books");
        }
    }
}
