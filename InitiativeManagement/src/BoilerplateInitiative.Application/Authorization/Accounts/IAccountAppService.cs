using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerplateInitiative.Authorization.Accounts.Dto;

namespace BoilerplateInitiative.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
