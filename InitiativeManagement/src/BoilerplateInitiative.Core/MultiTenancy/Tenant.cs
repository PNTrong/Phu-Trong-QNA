using Abp.MultiTenancy;
using BoilerplateInitiative.Authorization.Users;

namespace BoilerplateInitiative.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}