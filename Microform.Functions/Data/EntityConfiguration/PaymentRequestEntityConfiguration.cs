using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class PaymentRequestEntityConfiguration : IEntityTypeConfiguration<PaymentRequestEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentRequestEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ApplicationRequest).WithMany();
            builder.HasOne(x => x.PaymentRequestType).WithMany();
            builder.Property(x => x.ApplicationRequestId).IsRequired();
        }
    }
}
