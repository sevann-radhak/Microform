using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class PaymentRequestStatusEntityConfiguration : IEntityTypeConfiguration<PaymentRequestStatusEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentRequestStatusEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasMaxLength(100).IsRequired();
        }
    }
}
