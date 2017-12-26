using Abp.Domain.Entities;
using BoilerplateInitiative.FieldGroups;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoilerplateInitiative.Fields
{
    [Table("Fields")]
    public class Field : Entity<long>
    {
        [ForeignKey("FieldGroupId")]
        public virtual FieldGroup FieldGroup { get; set; }

        public virtual int? FieldGroupId { get; set; }

        public virtual string FieldName { set; get; }

        public virtual bool IsDeactive { set; get; }
    }
}