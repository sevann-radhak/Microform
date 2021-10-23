using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 37, 56, 655, DateTimeKind.Utc).AddTicks(7788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 12, 19, 607, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.CreateTable(
                name: "PaymentRequestEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationRequestId = table.Column<int>(nullable: false),
                    PaymentRequestTypeId = table.Column<int>(nullable: false),
                    InstrumentIdentifierTokenId = table.Column<string>(nullable: true),
                    PaymentInstrumentTokenId = table.Column<string>(nullable: true),
                    ShippingAddressTokenId = table.Column<string>(nullable: true),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequestEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentRequestEntity_ApplicationRequestEntity_ApplicationRequestId",
                        column: x => x.ApplicationRequestId,
                        principalTable: "ApplicationRequestEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentRequestEntity_PaymentRequestTypeEntity_PaymentRequestTypeId",
                        column: x => x.PaymentRequestTypeId,
                        principalTable: "PaymentRequestTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequestEntity_ApplicationRequestId",
                table: "PaymentRequestEntity",
                column: "ApplicationRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequestEntity_PaymentRequestTypeId",
                table: "PaymentRequestEntity",
                column: "PaymentRequestTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentRequestEntity");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedUtcTime",
                table: "ApplicationRequestEntity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 23, 19, 12, 19, 607, DateTimeKind.Utc).AddTicks(1130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 23, 19, 37, 56, 655, DateTimeKind.Utc).AddTicks(7788));
        }
    }
}
