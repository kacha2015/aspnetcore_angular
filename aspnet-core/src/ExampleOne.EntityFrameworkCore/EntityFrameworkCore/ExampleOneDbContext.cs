﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ExampleOne.Authorization.Roles;
using ExampleOne.Authorization.Users;
using ExampleOne.MultiTenancy;
using ExampleOne.Products;

namespace ExampleOne.EntityFrameworkCore
{
    public class ExampleOneDbContext : AbpZeroDbContext<Tenant, Role, User, ExampleOneDbContext>
    {
       
        public ExampleOneDbContext(DbContextOptions<ExampleOneDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
