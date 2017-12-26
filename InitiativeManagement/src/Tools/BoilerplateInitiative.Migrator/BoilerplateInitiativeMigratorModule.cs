using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BoilerplateInitiative.EntityFramework;

namespace BoilerplateInitiative.Migrator
{
    [DependsOn(typeof(BoilerplateInitiativeDataModule))]
    public class BoilerplateInitiativeMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BoilerplateInitiativeDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}