using System.Threading.Tasks;
using ExampleOne.Configuration.Dto;

namespace ExampleOne.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
