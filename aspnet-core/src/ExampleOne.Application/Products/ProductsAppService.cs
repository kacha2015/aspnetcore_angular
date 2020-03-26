using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace ExampleOne.Products
{
    public class ProductsAppService : CrudAppService<Product, ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}
