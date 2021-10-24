using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class PaymentRequestTypeEntityConfiguration : IEntityTypeConfiguration<PaymentRequestTypeEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentRequestTypeEntity> builder)
        {
            builder.ToTable("PaymentRequestType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.RequestType).HasMaxLength(100).IsRequired();
        }
    }
}
