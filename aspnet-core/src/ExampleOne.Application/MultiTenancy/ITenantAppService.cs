using Abp.Application.Services;
using ExampleOne.MultiTenancy.Dto;

namespace ExampleOne.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

