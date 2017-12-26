using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using BoilerplateInitiative.FieldGroups.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoilerplateInitiative.FieldGroups
{
    public class FieldGroupAppService : IFieldGroupAppService
    {
        private readonly IRepository<FieldGroup> _repository;

        public FieldGroupAppService(IRepository<FieldGroup> repository)
        {
            _repository = repository;
        }

        public async Task<GetAllFieldGroupOutput> GetAll()
        {
            var fieldGroups = await _repository.GetAllListAsync();
            return new GetAllFieldGroupOutput
            {
                FieldGroups = fieldGroups.MapTo<List<FieldGroupDto>>()
            };
        }
    }
}