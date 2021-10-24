using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class PaymentRequestResultEntityConfiguration : IEntityTypeConfiguration<PaymentRequestResultEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentRequestResultEntity> builder)
        {
            builder.ToTable("PaymentRequestResult");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.PaymentRequest).WithMany();
            builder.HasOne(x => x.PaymentRequestStatus).WithMany();
            builder.Property(x => x.PaymentRequestId).IsRequired();
            builder.Property(x => x.ResultId).HasMaxLength(1000);
            builder.Property(x => x.StatusId).IsRequired();
        }
    }
}
