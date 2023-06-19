using Abp.Application.Services;
using projectAngular.MultiTenancy.Dto;

namespace projectAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

