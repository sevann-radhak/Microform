using Microform.Functions.Data;
using Microform.Functions.Helpers;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(Microform.Functions.Startup))]
namespace Microform.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<MicroformContext>(
                options => options
                .UseSqlServer(Environment.GetEnvironmentVariable(MicroformConstants.SQL_CONNECTION_STRING, EnvironmentVariableTarget.Process)));
        }
    }
}
