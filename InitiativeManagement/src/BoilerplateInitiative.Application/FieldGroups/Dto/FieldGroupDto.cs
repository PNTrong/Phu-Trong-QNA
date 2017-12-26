using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace BoilerplateInitiative.FieldGroups.Dto
{
    [AutoMapFrom(typeof(FieldGroup)), AutoMapTo(typeof(FieldGroup))]
    public class FieldGroupDto : EntityDto<int>
    {
        public virtual string Name { set; get; }

        public virtual string Description { set; get; }

        public virtual DateTime CreationTime { get; set; }
    }
}