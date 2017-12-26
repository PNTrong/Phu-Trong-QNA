using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace BoilerplateInitiative.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BoilerplateInitiativeControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}