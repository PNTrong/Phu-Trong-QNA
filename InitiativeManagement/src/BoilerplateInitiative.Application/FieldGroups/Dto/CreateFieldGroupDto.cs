using Abp.AutoMapper;

namespace BoilerplateInitiative.FieldGroups.Dto
{
    [AutoMapTo(typeof(FieldGroup))]
    public class CreateFieldGroupDto
    {
        public virtual string Name { set; get; }

        public virtual string Description { set; get; }
    }
}