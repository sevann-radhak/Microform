﻿// <auto-generated />
using System;
using Microform.Functions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Microform.Functions.Migrations
{
    [DbContext(typeof(MicroformContext))]
    [Migration("20211023193756_entities10")]
    partial class entities10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microform.Functions.Data.Entities.ApplicationInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<DateTime>("CreatedUtcTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ApplicationInfoEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.ApplicationLanguageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("ApplicationLanguageEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.ApplicationPayerInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ApplicationPayerInfoEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.ApplicationRequestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationInfoId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationPayerInfoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedUtcTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 10, 23, 19, 37, 56, 655, DateTimeKind.Utc).AddTicks(7788));

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("OrderInfo")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PaymentKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ReferenceId")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("TransactionKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationInfoId");

                    b.HasIndex("ApplicationPayerInfoId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("LocationId");

                    b.ToTable("ApplicationRequestEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.ApplicationRequestStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("ApplicationRequestStatusEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.CybersourceConfigurationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthenticationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnableLog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyFilename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeysDirectory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantKeyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantsecretKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunEnvironment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CybersourceConfigurationEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.LocationInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedUtcTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("LocationInfoEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.MerchantInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedUtcTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CybersourceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MerchantName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("MerchantInfoEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.PaymentRequestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationRequestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedUtcTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstrumentIdentifierTokenId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentInstrumentTokenId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentRequestTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddressTokenId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationRequestId");

                    b.HasIndex("PaymentRequestTypeId");

                    b.ToTable("PaymentRequestEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.PaymentRequestStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("PaymentRequestStatusEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.PaymentRequestTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RequestType")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("PaymentRequestTypeEntity");
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.ApplicationRequestEntity", b =>
                {
                    b.HasOne("Microform.Functions.Data.Entities.ApplicationInfoEntity", "ApplicationInfo")
                        .WithMany("ApplicationRequests")
                        .HasForeignKey("ApplicationInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microform.Functions.Data.Entities.ApplicationPayerInfoEntity", "ApplicationPayerInfo")
                        .WithMany("ApplicationRequests")
                        .HasForeignKey("ApplicationPayerInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microform.Functions.Data.Entities.ApplicationLanguageEntity", "Language")
                        .WithMany("ApplicationRequests")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microform.Functions.Data.Entities.LocationInfoEntity", "Location")
                        .WithMany("ApplicationRequests")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microform.Functions.Data.Entities.PaymentRequestEntity", b =>
                {
                    b.HasOne("Microform.Functions.Data.Entities.ApplicationRequestEntity", "ApplicationRequest")
                        .WithMany()
                        .HasForeignKey("ApplicationRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microform.Functions.Data.Entities.PaymentRequestTypeEntity", "PaymentRequestType")
                        .WithMany()
                        .HasForeignKey("PaymentRequestTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
