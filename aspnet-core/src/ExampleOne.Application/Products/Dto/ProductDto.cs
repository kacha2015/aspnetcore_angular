﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace ExampleOne.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    [AutoMapTo(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
