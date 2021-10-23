using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 12, 19, 607, DateTimeKind.Utc).AddTicks(1130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 7, 22, 863, DateTimeKind.Utc).AddTicks(5472));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 7, 22, 863, DateTimeKind.Utc).AddTicks(5472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 12, 19, 607, DateTimeKind.Utc).AddTicks(1130));
        }
    }
}
