using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class FirstMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestResult",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 1, 13, 6, 232, DateTimeKind.Utc).AddTicks(5156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 689, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequest",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 1, 13, 6, 222, DateTimeKind.Utc).AddTicks(8215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 681, DateTimeKind.Utc).AddTicks(2100));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestResult",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 689, DateTimeKind.Utc).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 24, 1, 13, 6, 232, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 24, 1, 12, 44, 681, DateTimeKind.Utc).AddTicks(2100),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 24, 1, 13, 6, 222, DateTimeKind.Utc).AddTicks(8215));
        }
    }
}
