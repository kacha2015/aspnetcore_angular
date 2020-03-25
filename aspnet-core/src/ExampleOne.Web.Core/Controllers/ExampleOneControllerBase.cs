using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ExampleOne.Controllers
{
    public abstract class ExampleOneControllerBase: AbpController
    {
        protected ExampleOneControllerBase()
        {
            LocalizationSourceName = ExampleOneConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
