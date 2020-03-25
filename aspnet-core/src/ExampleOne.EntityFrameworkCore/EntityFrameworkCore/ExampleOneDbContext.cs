using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ExampleOne.Authorization.Roles;
using ExampleOne.Authorization.Users;
using ExampleOne.MultiTenancy;

namespace ExampleOne.EntityFrameworkCore
{
    public class ExampleOneDbContext : AbpZeroDbContext<Tenant, Role, User, ExampleOneDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ExampleOneDbContext(DbContextOptions<ExampleOneDbContext> options)
            : base(options)
        {
        }
    }
}
