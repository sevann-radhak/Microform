using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationPayerInfoEntity_ApplicationPayerInfoId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_LanguageId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationId",
                table: "ApplicationRequestEntity");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "ApplicationRequestEntity",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "ApplicationRequestEntity",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 7, 22, 863, DateTimeKind.Utc).AddTicks(5472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationPayerInfoId",
                table: "ApplicationRequestEntity",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationInfoId",
                table: "ApplicationRequestEntity",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity",
                column: "ApplicationInfoId",
                principalTable: "ApplicationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationPayerInfoEntity_ApplicationPayerInfoId",
                table: "ApplicationRequestEntity",
                column: "ApplicationPayerInfoId",
                principalTable: "ApplicationPayerInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_LanguageId",
                table: "ApplicationRequestEntity",
                column: "LanguageId",
                principalTable: "ApplicationLanguageEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationId",
                table: "ApplicationRequestEntity",
                column: "LocationId",
                principalTable: "LocationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationPayerInfoEntity_ApplicationPayerInfoId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_LanguageId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationId",
                table: "ApplicationRequestEntity");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "ApplicationRequestEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "ApplicationRequestEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 7, 22, 863, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationPayerInfoId",
                table: "ApplicationRequestEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationInfoId",
                table: "ApplicationRequestEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity",
                column: "ApplicationInfoId",
                principalTable: "ApplicationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationPayerInfoEntity_ApplicationPayerInfoId",
                table: "ApplicationRequestEntity",
                column: "ApplicationPayerInfoId",
                principalTable: "ApplicationPayerInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_LanguageId",
                table: "ApplicationRequestEntity",
                column: "LanguageId",
                principalTable: "ApplicationLanguageEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationId",
                table: "ApplicationRequestEntity",
                column: "LocationId",
                principalTable: "LocationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
