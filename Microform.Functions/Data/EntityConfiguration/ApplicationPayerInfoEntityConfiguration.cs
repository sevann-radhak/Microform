using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class ApplicationPayerInfoEntityConfiguration : IEntityTypeConfiguration<ApplicationPayerInfoEntity>
    {
        public void Configure(EntityTypeBuilder<ApplicationPayerInfoEntity> builder)
        {
            builder.ToTable("ApplicationPayerInfo");

            builder.HasKey(x => x.Id);
        }
    }
}
