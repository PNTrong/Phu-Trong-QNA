using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BoilerplateInitiative.MultiTenancy.Dto;

namespace BoilerplateInitiative.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
