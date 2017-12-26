using Abp.Web.Mvc.Views;

namespace BoilerplateInitiative.Web.Views
{
    public abstract class BoilerplateInitiativeWebViewPageBase : BoilerplateInitiativeWebViewPageBase<dynamic>
    {

    }

    public abstract class BoilerplateInitiativeWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BoilerplateInitiativeWebViewPageBase()
        {
            LocalizationSourceName = BoilerplateInitiativeConsts.LocalizationSourceName;
        }
    }
}