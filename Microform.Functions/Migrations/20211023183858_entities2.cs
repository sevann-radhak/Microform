using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationKey",
                table: "ApplicationInfoEntity",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationName",
                table: "ApplicationInfoEntity",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationInfoEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ApplicationInfoEntity",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
