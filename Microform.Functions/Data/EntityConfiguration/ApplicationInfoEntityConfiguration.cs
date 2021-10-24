using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class ApplicationInfoEntityConfiguration : IEntityTypeConfiguration<ApplicationInfoEntity>
    {
        public void Configure(EntityTypeBuilder<ApplicationInfoEntity> builder)
        {
            builder.ToTable("ApplicationInfo");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.ApplicationKey).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ApplicationName).HasMaxLength(450).IsRequired();
        }
    }
}
