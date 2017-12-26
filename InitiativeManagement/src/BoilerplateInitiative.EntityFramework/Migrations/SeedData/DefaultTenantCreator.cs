using System.Linq;
using BoilerplateInitiative.EntityFramework;
using BoilerplateInitiative.MultiTenancy;

namespace BoilerplateInitiative.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly BoilerplateInitiativeDbContext _context;

        public DefaultTenantCreator(BoilerplateInitiativeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
