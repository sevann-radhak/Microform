using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities13 : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentRequestEntity_ApplicationRequestEntity_ApplicationRequestId",
                table: "PaymentRequestEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRequestEntity",
                table: "ApplicationRequestEntity");

            migrationBuilder.RenameTable(
                name: "ApplicationRequestEntity",
                newName: "ApplicationRequest");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequestEntity_LocationId",
                table: "ApplicationRequest",
                newName: "IX_ApplicationRequest_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequestEntity_LanguageId",
                table: "ApplicationRequest",
                newName: "IX_ApplicationRequest_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequestEntity_ApplicationPayerInfoId",
                table: "ApplicationRequest",
                newName: "IX_ApplicationRequest_ApplicationPayerInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequestEntity_ApplicationInfoId",
                table: "ApplicationRequest",
                newName: "IX_ApplicationRequest_ApplicationInfoId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequest",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 48, 49, 500, DateTimeKind.Utc).AddTicks(4359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 44, 53, 294, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRequest",
                table: "ApplicationRequest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequest_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequest",
                column: "ApplicationInfoId",
                principalTable: "ApplicationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequest_ApplicationPayerInfoEntity_ApplicationPayerInfoId",
                table: "ApplicationRequest",
                column: "ApplicationPayerInfoId",
                principalTable: "ApplicationPayerInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequest_ApplicationLanguageEntity_LanguageId",
                table: "ApplicationRequest",
                column: "LanguageId",
                principalTable: "ApplicationLanguageEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequest_LocationInfoEntity_LocationId",
                table: "ApplicationRequest",
                column: "LocationId",
                principalTable: "LocationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentRequestEntity_ApplicationRequest_ApplicationRequestId",
                table: "PaymentRequestEntity",
                column: "ApplicationRequestId",
                principalTable: "ApplicationRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequest_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequest_ApplicationPayerInfoEntity_ApplicationPayerInfoId",
                table: "ApplicationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequest_ApplicationLanguageEntity_LanguageId",
                table: "ApplicationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequest_LocationInfoEntity_LocationId",
                table: "ApplicationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentRequestEntity_ApplicationRequest_ApplicationRequestId",
                table: "PaymentRequestEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRequest",
                table: "ApplicationRequest");

            migrationBuilder.RenameTable(
                name: "ApplicationRequest",
                newName: "ApplicationRequestEntity");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequest_LocationId",
                table: "ApplicationRequestEntity",
                newName: "IX_ApplicationRequestEntity_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequest_LanguageId",
                table: "ApplicationRequestEntity",
                newName: "IX_ApplicationRequestEntity_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequest_ApplicationPayerInfoId",
                table: "ApplicationRequestEntity",
                newName: "IX_ApplicationRequestEntity_ApplicationPayerInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRequest_ApplicationInfoId",
                table: "ApplicationRequestEntity",
                newName: "IX_ApplicationRequestEntity_ApplicationInfoId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 44, 53, 294, DateTimeKind.Utc).AddTicks(3002),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 48, 49, 500, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRequestEntity",
                table: "ApplicationRequestEntity",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentRequestEntity_ApplicationRequestEntity_ApplicationRequestId",
                table: "PaymentRequestEntity",
                column: "ApplicationRequestId",
                principalTable: "ApplicationRequestEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
