using Microform.Functions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Microform.Functions.Data.EntityConfiguration
{
    public class ApplicationRequestResultEntityConfiguration : IEntityTypeConfiguration<ApplicationRequestResultEntity>
    {
        public void Configure(EntityTypeBuilder<ApplicationRequestResultEntity> builder)
        {
            builder.ToTable("ApplicationRequestResult");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ApplicationRequest).WithMany();
            builder.HasOne(x => x.ApplicationRequestStatus).WithMany();
            builder.Property(x => x.CreatedUtcTime).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.ApplicationRequestId).IsRequired();
            builder.Property(x => x.ReturnDesicion).HasMaxLength(1000);
            builder.Property(x => x.StatusId).IsRequired();
        }
    }
}
