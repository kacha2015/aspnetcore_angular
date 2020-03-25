using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ExampleOne.EntityFrameworkCore
{
    public static class ExampleOneDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ExampleOneDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ExampleOneDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
