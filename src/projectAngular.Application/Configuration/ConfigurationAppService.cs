using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using projectAngular.Configuration.Dto;

namespace projectAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : projectAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
