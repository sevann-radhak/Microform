using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class MerchantInfoEntityConfiguration : IEntityTypeConfiguration<MerchantInfoEntity>
    {
        public void Configure(EntityTypeBuilder<MerchantInfoEntity> builder)
        {
            builder.ToTable("MerchantInfo");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.CybersourceId).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MerchantId).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MerchantName).HasMaxLength(100);
        }
    }
}
