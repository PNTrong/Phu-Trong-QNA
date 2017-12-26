using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerplateInitiative.Sessions.Dto;

namespace BoilerplateInitiative.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
