using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ApplicationInfoId",
                table: "ApplicationRequestEntity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity",
                column: "ApplicationInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity",
                column: "ApplicationInfoId",
                principalTable: "ApplicationInfoEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationRequestEntity_ApplicationInfoId",
                table: "ApplicationRequestEntity");

            migrationBuilder.DropColumn(
                name: "ApplicationInfoId",
                table: "ApplicationRequestEntity");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationInfoEntityId",
                table: "ApplicationRequestEntity",
                type: "int",
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
    }
}
