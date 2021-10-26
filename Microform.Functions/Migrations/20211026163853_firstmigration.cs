using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microform.Functions.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationInfo",
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
                    table.PrimaryKey("PK_ApplicationInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationPayerInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPayerInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRequestStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRequestStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CybersourceConfiguration",
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
                    table.PrimaryKey("PK_CybersourceConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationInfo",
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
                    table.PrimaryKey("PK_LocationInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchantInfo",
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
                    table.PrimaryKey("PK_MerchantInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequestStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequestStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequestType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    RequestType = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequestType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationPayerToken",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationPayerInfoId = table.Column<int>(nullable: false),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false),
                    InstrumentIdentifierTokenId = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    PaymentInstrumentTokenId = table.Column<string>(maxLength: 100, nullable: false),
                    ShippingAddressTokenId = table.Column<string>(maxLength: 100, nullable: false),
                    UpdatedUtcTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPayerToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationPayerToken_ApplicationPayerInfo_ApplicationPayerInfoId",
                        column: x => x.ApplicationPayerInfoId,
                        principalTable: "ApplicationPayerInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationInfoId = table.Column<int>(nullable: false),
                    ApplicationPayerInfoId = table.Column<int>(nullable: false),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 10, 26, 16, 38, 53, 511, DateTimeKind.Utc).AddTicks(1942)),
                    LanguageId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    MerchantId = table.Column<string>(maxLength: 100, nullable: false),
                    OrderInfo = table.Column<string>(maxLength: 100, nullable: true),
                    PaymentKey = table.Column<string>(maxLength: 100, nullable: false),
                    ReferenceId = table.Column<string>(maxLength: 1000, nullable: true),
                    TransactionKey = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRequest_ApplicationInfo_ApplicationInfoId",
                        column: x => x.ApplicationInfoId,
                        principalTable: "ApplicationInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationRequest_ApplicationPayerInfo_ApplicationPayerInfoId",
                        column: x => x.ApplicationPayerInfoId,
                        principalTable: "ApplicationPayerInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationRequest_ApplicationLanguage_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "ApplicationLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationRequest_LocationInfo_LocationId",
                        column: x => x.LocationId,
                        principalTable: "LocationInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRequestResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationRequestId = table.Column<int>(nullable: false),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 10, 26, 16, 38, 53, 522, DateTimeKind.Utc).AddTicks(4204)),
                    ReturnDesicion = table.Column<int>(maxLength: 1000, nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    ApplicationRequestStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRequestResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRequestResult_ApplicationRequest_ApplicationRequestId",
                        column: x => x.ApplicationRequestId,
                        principalTable: "ApplicationRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationRequestResult_ApplicationRequestStatus_ApplicationRequestStatusId",
                        column: x => x.ApplicationRequestStatusId,
                        principalTable: "ApplicationRequestStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationRequestId = table.Column<int>(nullable: false),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false),
                    InstrumentIdentifierTokenId = table.Column<string>(nullable: true),
                    PaymentInstrumentTokenId = table.Column<string>(nullable: true),
                    PaymentRequestTypeId = table.Column<int>(nullable: false),
                    ShippingAddressTokenId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentRequest_ApplicationRequest_ApplicationRequestId",
                        column: x => x.ApplicationRequestId,
                        principalTable: "ApplicationRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentRequest_PaymentRequestType_PaymentRequestTypeId",
                        column: x => x.PaymentRequestTypeId,
                        principalTable: "PaymentRequestType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequestResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUtcTime = table.Column<DateTime>(nullable: false),
                    PaymentRequestId = table.Column<int>(nullable: false),
                    ResultId = table.Column<string>(maxLength: 1000, nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    PaymentRequestStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequestResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentRequestResult_PaymentRequest_PaymentRequestId",
                        column: x => x.PaymentRequestId,
                        principalTable: "PaymentRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentRequestResult_PaymentRequestStatus_PaymentRequestStatusId",
                        column: x => x.PaymentRequestStatusId,
                        principalTable: "PaymentRequestStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPayerToken_ApplicationPayerInfoId",
                table: "ApplicationPayerToken",
                column: "ApplicationPayerInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequest_ApplicationInfoId",
                table: "ApplicationRequest",
                column: "ApplicationInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequest_ApplicationPayerInfoId",
                table: "ApplicationRequest",
                column: "ApplicationPayerInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequest_LanguageId",
                table: "ApplicationRequest",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequest_LocationId",
                table: "ApplicationRequest",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestResult_ApplicationRequestId",
                table: "ApplicationRequestResult",
                column: "ApplicationRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRequestResult_ApplicationRequestStatusId",
                table: "ApplicationRequestResult",
                column: "ApplicationRequestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequest_ApplicationRequestId",
                table: "PaymentRequest",
                column: "ApplicationRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequest_PaymentRequestTypeId",
                table: "PaymentRequest",
                column: "PaymentRequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequestResult_PaymentRequestId",
                table: "PaymentRequestResult",
                column: "PaymentRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequestResult_PaymentRequestStatusId",
                table: "PaymentRequestResult",
                column: "PaymentRequestStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationPayerToken");

            migrationBuilder.DropTable(
                name: "ApplicationRequestResult");

            migrationBuilder.DropTable(
                name: "CybersourceConfiguration");

            migrationBuilder.DropTable(
                name: "MerchantInfo");

            migrationBuilder.DropTable(
                name: "PaymentRequestResult");

            migrationBuilder.DropTable(
                name: "ApplicationRequestStatus");

            migrationBuilder.DropTable(
                name: "PaymentRequest");

            migrationBuilder.DropTable(
                name: "PaymentRequestStatus");

            migrationBuilder.DropTable(
                name: "ApplicationRequest");

            migrationBuilder.DropTable(
                name: "PaymentRequestType");

            migrationBuilder.DropTable(
                name: "ApplicationInfo");

            migrationBuilder.DropTable(
                name: "ApplicationPayerInfo");

            migrationBuilder.DropTable(
                name: "ApplicationLanguage");

            migrationBuilder.DropTable(
                name: "LocationInfo");
        }
    }
}
