using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace projectAngular.Controllers
{
    public abstract class projectAngularControllerBase: AbpController
    {
        protected projectAngularControllerBase()
        {
            LocalizationSourceName = projectAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
