using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace ExampleOne.Products
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
