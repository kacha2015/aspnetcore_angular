using System.Threading.Tasks;
using Abp.Application.Services;
using ExampleOne.Sessions.Dto;

namespace ExampleOne.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
