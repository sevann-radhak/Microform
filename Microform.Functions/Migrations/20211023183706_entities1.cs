using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class entities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationInfoEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationKey = table.Column<string>(maxLength: 100, nullable: false),
                    ApplicationName = table.Column<string>(maxLength: 450, nullable: false),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationInfoEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationPayerInfoEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPayerInfoEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRequestStatusEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRequestStatusEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CybersourceConfigurationEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthenticationType = table.Column<string>(nullable: false),
                    EnableLog = table.Column<string>(nullable: false),
                    KeyAlias = table.Column<string>(nullable: false),
                    KeysDirectory = table.Column<string>(nullable: false),
                    KeyFilename = table.Column<string>(nullable: false),
                    KeyPass = table.Column<string>(nullable: false),
                    MerchantID = table.Column<string>(nullable: false),
                    MerchantKeyId = table.Column<string>(nullable: false),
                    MerchantsecretKey = table.Column<string>(nullable: false),
                    RunEnvironment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CybersourceConfigurationEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationInfoEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false),
                    LocationId = table.Column<string>(maxLength: 100, nullable: false),
                    LocationName = table.Column<string>(maxLength: 100, nullable: true),
                    MerchantId = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationInfoEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchantInfoEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false),
                    CybersourceId = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    MerchantId = table.Column<string>(maxLength: 100, nullable: false),
                    MerchantName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantInfoEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequestStatusEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequestStatusEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequestTypeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    RequestType = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequestTypeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRequestEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationPayerInfoId = table.Column<int>(nullable: true),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false),
                    MerchantId = table.Column<string>(maxLength: 100, nullable: false),
                    OrderInfo = table.Column<string>(maxLength: 100, nullable: true),
                    PaymentKey = table.Column<string>(maxLength: 100, nullable: false),
                    ReferenceId = table.Column<string>(maxLength: 1000, nullable: true),
                    TransactionKey = table.Column<string>(maxLength: 100, nullable: false),
                    ApplicationInfoEntityId = table.Column<int>(nullable: true),
                    ApplicationLanguageEntityId = table.Column<int>(nullable: true),
                    LocationInfoEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRequestEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRequestEntity_ApplicationInfoEntity_ApplicationInfoEntityId",
                        column: x => x.ApplicationInfoEntityId,
                        principalTable: "ApplicationInfoEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationRequestEntity_ApplicationLanguageEntity_ApplicationLanguageEntityId",
                        column: x => x.ApplicationLanguageEntityId,
                        principalTable: "ApplicationLanguageEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationRequestEntity_ApplicationPayerInfoEntity_ApplicationPayerInfoId",
                        column: x => x.ApplicationPayerInfoId,
                        principalTable: "ApplicationPayerInfoEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationRequestEntity_LocationInfoEntity_LocationInfoEntityId",
                        column: x => x.LocationInfoEntityId,
                        principalTable: "LocationInfoEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_ApplicationInfoEntityId",
                table: "ApplicationRequestEntity",
                column: "ApplicationInfoEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_ApplicationLanguageEntityId",
                table: "ApplicationRequestEntity",
                column: "ApplicationLanguageEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_ApplicationPayerInfoId",
                table: "ApplicationRequestEntity",
                column: "ApplicationPayerInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestEntity_LocationInfoEntityId",
                table: "ApplicationRequestEntity",
                column: "LocationInfoEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationRequestEntity");

            migrationBuilder.DropTable(
                name: "ApplicationRequestStatusEntity");

            migrationBuilder.DropTable(
                name: "CybersourceConfigurationEntity");

            migrationBuilder.DropTable(
                name: "MerchantInfoEntity");

            migrationBuilder.DropTable(
                name: "PaymentRequestStatusEntity");

            migrationBuilder.DropTable(
                name: "PaymentRequestTypeEntity");

            migrationBuilder.DropTable(
                name: "ApplicationInfoEntity");

            migrationBuilder.DropTable(
                name: "ApplicationPayerInfoEntity");

            migrationBuilder.DropTable(
                name: "LocationInfoEntity");
        }
    }
}
