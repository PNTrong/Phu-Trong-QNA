using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoilerplateInitiative.FieldGroups
{
    [Table("FieldGroups")]
    public class FieldGroup : Entity, IHasCreationTime
    {
        public virtual string Name { set; get; }

        public virtual DateTime CreationTime { get; set; }

        public virtual bool IsDeactive { set; get; }

        public FieldGroup()
        {
            CreationTime = DateTime.Now;
            IsDeactive = false;
        }
    }
}