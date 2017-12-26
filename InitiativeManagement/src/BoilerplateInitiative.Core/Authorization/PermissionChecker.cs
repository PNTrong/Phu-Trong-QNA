using Abp.Authorization;
using BoilerplateInitiative.Authorization.Roles;
using BoilerplateInitiative.Authorization.Users;

namespace BoilerplateInitiative.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
