using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_ApplicationLanguageEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationInfoEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRequestEntity_ApplicationLanguageEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRequestEntity_LocationInfoEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropColumn(
                name: "ApplicationLanguageEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropColumn(
                name: "LocationInfoEntityId",
                table: "ApplicationRequestEntity");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "ApplicationRequestEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "ApplicationRequestEntity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_LanguageId",
                table: "ApplicationRequestEntity",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_LocationId",
                table: "ApplicationRequestEntity",
                column: "LocationId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_LanguageId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRequestEntity_LanguageId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRequestEntity_LocationId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "ApplicationRequestEntity");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationLanguageEntityId",
                table: "ApplicationRequestEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationInfoEntityId",
                table: "ApplicationRequestEntity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_ApplicationLanguageEntityId",
                table: "ApplicationRequestEntity",
                column: "ApplicationLanguageEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_LocationInfoEntityId",
                table: "ApplicationRequestEntity",
                column: "LocationInfoEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_ApplicationLanguageEntityId",
                table: "ApplicationRequestEntity",
                column: "ApplicationLanguageEntityId",
                principalTable: "ApplicationLanguageEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationInfoEntityId",
                table: "ApplicationRequestEntity",
                column: "LocationInfoEntityId",
                principalTable: "LocationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
