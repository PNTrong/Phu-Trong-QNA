using Abp.Application.Services;
using BoilerplateInitiative.FieldGroups.Dto;
using System.Threading.Tasks;

namespace BoilerplateInitiative.FieldGroups
{
    public interface IFieldGroupAppService : IApplicationService
    {
        Task<GetAllFieldGroupOutput> GetAll();
    }
}