using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class ApplicationRequestStatusEntityConfiguration : IEntityTypeConfiguration<ApplicationRequestStatusEntity>
    {
        public void Configure(EntityTypeBuilder<ApplicationRequestStatusEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasMaxLength(100).IsRequired();
        }
    }
}
