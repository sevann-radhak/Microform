using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class FirstMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestResult",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 689, DateTimeKind.Utc).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 24, 0, 9, 45, 880, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequest",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 681, DateTimeKind.Utc).AddTicks(2100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 24, 0, 9, 45, 872, DateTimeKind.Utc).AddTicks(5915));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestResult",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 0, 9, 45, 880, DateTimeKind.Utc).AddTicks(3797),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 689, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 0, 9, 45, 872, DateTimeKind.Utc).AddTicks(5915),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 681, DateTimeKind.Utc).AddTicks(2100));
        }
    }
}
