using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ExampleOne.Configuration.Dto;

namespace ExampleOne.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ExampleOneAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
