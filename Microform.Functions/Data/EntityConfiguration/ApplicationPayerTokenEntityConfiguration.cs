using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class ApplicationPayerTokenEntityConfiguration : IEntityTypeConfiguration<ApplicationPayerTokenEntity>
    {
        public void Configure(EntityTypeBuilder<ApplicationPayerTokenEntity> builder)
        {
            builder.ToTable("ApplicationPayerToken");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ApplicationPayerInfo).WithMany();
            builder.Property(x => x.ApplicationPayerInfoId).IsRequired();
            builder.Property(x => x.InstrumentIdentifierTokenId).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PaymentInstrumentTokenId).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ShippingAddressTokenId).HasMaxLength(100).IsRequired();
        }
    }
}
