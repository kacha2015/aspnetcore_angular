using Abp.Domain.Entities;
using System;

namespace ExampleOne.Products
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
