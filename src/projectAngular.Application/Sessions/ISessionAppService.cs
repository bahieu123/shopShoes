using System.Threading.Tasks;
using Abp.Application.Services;
using projectAngular.Sessions.Dto;

namespace projectAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
