using Microform.Functions.Data.Entities;
using Microform.Functions.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Microform.Functions.Data
{
    public class MicroformContext : DbContext
    {
        public MicroformContext(DbContextOptions<MicroformContext> options) : base(options)
        {

        }

        public DbSet<ApplicationLanguageEntity> ApplicationLanguageEntity { get; set; }

        public class FunctionContextFactory : IDesignTimeDbContextFactory<MicroformContext>
        {
            public MicroformContext CreateDbContext(string[] args)
            {
                DbContextOptionsBuilder<MicroformContext> optionsBuilder = new DbContextOptionsBuilder<MicroformContext>();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MicroformDataBase;Trusted_Connection=True;MultipleActiveResultSets=true");
                //Environment.GetEnvironmentVariable(MicroformConstants.SQL_CONNECTION_STRING, EnvironmentVariableTarget.Process));

                return new MicroformContext(optionsBuilder.Options);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MicroformContext).Assembly);

            //modelBuilder
            //    .Entity<ApplicationRequestEntity>()
            //    .HasOne(p => p.ApplicationInfo)
            //    .WithMany(b => b.ApplicationRequests);
        }
    }
}
