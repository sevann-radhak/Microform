using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class ApplicationLanguageEntityConfiguration : IEntityTypeConfiguration<ApplicationLanguageEntity>
    {
        public void Configure(EntityTypeBuilder<ApplicationLanguageEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Language).HasMaxLength(100).IsRequired();
        }
    }
}
