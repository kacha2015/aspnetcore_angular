using Abp.Domain.Entities;
using System;

namespace ExampleOne.Products
{
    public class Product : Entity<int>
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
