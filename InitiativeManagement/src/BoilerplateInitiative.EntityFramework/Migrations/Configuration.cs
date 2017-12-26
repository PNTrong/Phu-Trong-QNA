using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using BoilerplateInitiative.FieldGroups;
using BoilerplateInitiative.Fields;
using BoilerplateInitiative.Migrations.SeedData;
using EntityFramework.DynamicFilters;
using System;
using System.Data.Entity.Migrations;

namespace BoilerplateInitiative.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<BoilerplateInitiative.EntityFramework.BoilerplateInitiativeDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BoilerplateInitiative";
        }

        protected override void Seed(BoilerplateInitiative.EntityFramework.BoilerplateInitiativeDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.FieldGroups.AddOrUpdate(
            new FieldGroup { Name = "Giáo dục", CreationTime = DateTime.Now, IsDeactive = false },
            new FieldGroup { Name = "Quản lý nông nghiệp", CreationTime = DateTime.Now, IsDeactive = false },
            new FieldGroup { Name = "Nghiên cứu khoa học", CreationTime = DateTime.Now, IsDeactive = false }
            );

            context.Fields.AddOrUpdate(
                new Field { FieldName = "Toan", IsDeactive = false, FieldGroupId = 1 },
                new Field { FieldName = "Vật lý", IsDeactive = false, FieldGroupId = 1 }
            );

            context.SaveChanges();
        }
    }
}