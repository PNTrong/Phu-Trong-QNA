using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using BoilerplateInitiative.EntityFramework;

namespace BoilerplateInitiative
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(BoilerplateInitiativeCoreModule))]
    public class BoilerplateInitiativeDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BoilerplateInitiativeDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
