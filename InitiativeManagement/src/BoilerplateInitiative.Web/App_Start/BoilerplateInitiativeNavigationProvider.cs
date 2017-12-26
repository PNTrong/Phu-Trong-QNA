using Abp.Application.Navigation;
using Abp.Localization;
using BoilerplateInitiative.Authorization;

namespace BoilerplateInitiative.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class BoilerplateInitiativeNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", BoilerplateInitiativeConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "#tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "#users",
                        icon: "fa fa-users",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Roles",
                        L("Roles"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", BoilerplateInitiativeConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Initiatives",
                        L("Initiatives"),
                        url: "#/initiatives",
                        icon: "fa fa-info",
                        requiredPermissionName: PermissionNames.Pages_Initiatives
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Fields",
                        L("Fields"),
                        url: "#/fields",
                        icon: "fa fa-info",
                         requiredPermissionName: PermissionNames.Pages_Fields
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "FieldGroups",
                        L("FieldGroups"),
                        url: "#/fieldgroups",
                        icon: "fa fa-info",
                         requiredPermissionName: PermissionNames.Pages_FieldGroups
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BoilerplateInitiativeConsts.LocalizationSourceName);
        }
    }
}