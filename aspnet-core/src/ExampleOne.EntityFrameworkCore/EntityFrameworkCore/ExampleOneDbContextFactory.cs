using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ExampleOne.Configuration;
using ExampleOne.Web;

namespace ExampleOne.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ExampleOneDbContextFactory : IDesignTimeDbContextFactory<ExampleOneDbContext>
    {
        public ExampleOneDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ExampleOneDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ExampleOneDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ExampleOneConsts.ConnectionStringName));

            return new ExampleOneDbContext(builder.Options);
        }
    }
}
