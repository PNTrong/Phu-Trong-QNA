using System.Data.Common;
using Abp.Zero.EntityFramework;
using BoilerplateInitiative.Authorization.Roles;
using BoilerplateInitiative.Authorization.Users;
using BoilerplateInitiative.MultiTenancy;
using System.Data.Entity;
using BoilerplateInitiative.FieldGroups;
using BoilerplateInitiative.Fields;

namespace BoilerplateInitiative.EntityFramework
{
    public class BoilerplateInitiativeDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Field> Fields { get; set; }

        public virtual IDbSet<FieldGroup> FieldGroups { get; set; }
        /* NOTE:
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */

        public BoilerplateInitiativeDbContext()
            : base("Default")
        {
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BoilerplateInitiativeDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BoilerplateInitiativeDbContext since ABP automatically handles it.
         */

        public BoilerplateInitiativeDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        //This constructor is used in tests
        public BoilerplateInitiativeDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {
        }

        public BoilerplateInitiativeDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {
        }
    }
}