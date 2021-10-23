using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class LocationInfoEntityConfiguration : IEntityTypeConfiguration<LocationInfoEntity>
    {
        public void Configure(EntityTypeBuilder<LocationInfoEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LocationId).HasMaxLength(100).IsRequired();
            builder.Property(x => x.LocationName).HasMaxLength(100);
            builder.Property(x => x.MerchantId).HasMaxLength(100).IsRequired();
        }
    }
}
