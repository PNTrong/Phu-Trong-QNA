using Abp.AutoMapper;
using BoilerplateInitiative.Sessions.Dto;

namespace BoilerplateInitiative.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}