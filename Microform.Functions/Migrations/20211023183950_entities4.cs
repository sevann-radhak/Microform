using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationKey",
                table: "ApplicationInfoEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationName",
                table: "ApplicationInfoEntity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationInfoEntity",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ApplicationInfoEntity",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationKey",
                table: "ApplicationInfoEntity");

            migrationBuilder.DropColumn(
                name: "ApplicationName",
                table: "ApplicationInfoEntity");

            migrationBuilder.DropColumn(
                name: "CreatedUtcTime",
                table: "ApplicationInfoEntity");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ApplicationInfoEntity");
        }
    }
}
