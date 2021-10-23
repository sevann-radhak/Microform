using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class ApplicationRequestEntityConfiguration : IEntityTypeConfiguration<ApplicationRequestEntity>
    {
        

        public void Configure(EntityTypeBuilder<ApplicationRequestEntity> builder)
        {
            builder.ToTable("ApplicationRequest");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedUtcTime).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.ApplicationInfoId).IsRequired();
            builder.Property(x => x.ApplicationPayerInfoId).IsRequired();
            builder.Property(x => x.LanguageId).IsRequired();
            builder.Property(x => x.LocationId).IsRequired();
            builder.Property(x => x.MerchantId).HasMaxLength(100).IsRequired();
            builder.Property(x => x.OrderInfo).HasMaxLength(100);
            builder.Property(x => x.PaymentKey).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ReferenceId).HasMaxLength(1000);
            builder.Property(x => x.TransactionKey).HasMaxLength(100).IsRequired();
        }
    }
}
