using Microform.Functions.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Microform.Functions.Data
{
    public class MicroformContext : DbContext
    {
        public MicroformContext(DbContextOptions<MicroformContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MicroformContext).Assembly);
        }
    }

    public class FunctionContextFactory : IDesignTimeDbContextFactory<MicroformContext>
    {
        public MicroformContext CreateDbContext(string[] args)
        {
            // Setup config
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile($"{MicroformConstants.LOCAL_SETTINGS}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            // Get connection string from config
            string connectionString = config
                .GetValue<string>($"{MicroformConstants.VALUES}:{MicroformConstants.SQL_CONNECTION_STRING}");

            DbContextOptionsBuilder<MicroformContext> optionsBuilder = new DbContextOptionsBuilder<MicroformContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MicroformContext(optionsBuilder.Options);
        }
    }
}
