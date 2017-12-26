using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace BoilerplateInitiative.Authorization
{
    public class BoilerplateInitiativeAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Initiatives, L("Initiatives"));
            context.CreatePermission(PermissionNames.Pages_FieldGroups, L("FieldGroups"));
            context.CreatePermission(PermissionNames.Pages_Fields, L("Fields"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BoilerplateInitiativeConsts.LocalizationSourceName);
        }
    }
}