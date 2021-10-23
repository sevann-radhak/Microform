using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class CybersourceConfigurationEntityConfiguration : IEntityTypeConfiguration<CybersourceConfigurationEntity>
    {
        public void Configure(EntityTypeBuilder<CybersourceConfigurationEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AuthenticationType).IsRequired();
            builder.Property(x => x.EnableLog).IsRequired();
            builder.Property(x => x.KeyAlias).IsRequired();
            builder.Property(x => x.KeysDirectory).IsRequired();
            builder.Property(x => x.KeyFilename).IsRequired();
            builder.Property(x => x.KeyPass).IsRequired();
            builder.Property(x => x.MerchantID).IsRequired();
            builder.Property(x => x.MerchantKeyId).IsRequired();
            builder.Property(x => x.MerchantsecretKey).IsRequired();
            builder.Property(x => x.RunEnvironment).IsRequired();
        }
    }
}
