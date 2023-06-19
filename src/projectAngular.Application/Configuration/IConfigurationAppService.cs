using System.Threading.Tasks;
using projectAngular.Configuration.Dto;

namespace projectAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
