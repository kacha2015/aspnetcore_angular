using System.Threading.Tasks;
using Abp.Application.Services;
using ExampleOne.Authorization.Accounts.Dto;

namespace ExampleOne.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
