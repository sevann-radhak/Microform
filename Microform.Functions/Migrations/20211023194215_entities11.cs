using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 42, 15, 50, DateTimeKind.Utc).AddTicks(1152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 37, 56, 655, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.AddColumn<int>(
                name: "ApplicationInfoEntityId",
                table: "ApplicationRequestEntity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_ApplicationInfoEntityId",
                table: "ApplicationRequestEntity",
                column: "ApplicationInfoEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoEntityId",
                table: "ApplicationRequestEntity",
                column: "ApplicationInfoEntityId",
                principalTable: "ApplicationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRequestEntity_ApplicationInfoEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropColumn(
                name: "ApplicationInfoEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 37, 56, 655, DateTimeKind.Utc).AddTicks(7788),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 42, 15, 50, DateTimeKind.Utc).AddTicks(1152));
        }
    }
}
