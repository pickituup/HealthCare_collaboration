using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HealthCare.Configuration;
using HealthCare.Web;

namespace HealthCare.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HealthCareDbContextFactory : IDesignTimeDbContextFactory<HealthCareDbContext>
    {
        public HealthCareDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HealthCareDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HealthCareDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HealthCareConsts.ConnectionStringName));

            return new HealthCareDbContext(builder.Options);
        }
    }
}
